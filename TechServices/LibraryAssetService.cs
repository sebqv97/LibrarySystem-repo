﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using TechData;
using TechData.Interfaces;
using TechData.Models;

namespace TechServices
{
    public class LibraryAssetService : ILibraryAssetService
    {
        private readonly TechContext _context;

        public LibraryAssetService(TechContext context)
        {
            _context = context;
        }

        public void Add(LibraryAsset newAsset)
        {
            _context.Add(newAsset);
            newAsset.Status = _context.Statuses
                .FirstOrDefault(a => a.Name == "Valabil");
            _context.SaveChanges();
        }




        public void Delete(int id)
        {
            var assetToDelete = Get(id);
            _context.Remove(assetToDelete);
            _context.SaveChanges();
        }


        public LibraryAsset Get(int id)
        {
            return _context.LibraryAssets
                .Include(a => a.Status)
                .Include(a => a.Location)
                .FirstOrDefault(a => a.Id == id);
        }

        public IEnumerable<LibraryAsset> GetAll()
        {
            return _context.LibraryAssets
                .Include(a => a.Status)
                .Include(a => a.Location);
        }

        public string GetAuthorOrDirector(int id)
        {
            var isBook = _context.LibraryAssets
                .OfType<Book>().Any(a => a.Id == id);

            return isBook
                ? GetAuthor(id)
                : GetDirector(id);
        }

        public LibraryBranch GetCurrentLocation(int id)
        {
            return _context.LibraryAssets.First(a => a.Id == id).Location;
        }

        public string GetDeweyIndex(int id)
        {
            if (GetType(id) != "Book") return "N/A";
            var book = (Book)Get(id);
            return book.DeweyIndex;
        }

        public string GetIsbn(int id)
        {
            if (GetType(id) != "Book") return "N/A";
            var book = (Book)Get(id);
            return book.ISBN;
        }

        public LibraryCard GetLibraryCardByAssetId(int id)
        {
            return _context.LibraryCards
                .FirstOrDefault(c => c.Checkouts
                    .Select(a => a.LibraryAsset)
                    .Select(v => v.Id).Contains(id));
        }

        public string GetTitle(int id)
        {
            return _context.LibraryAssets.First(a => a.Id == id).Title;
        }

        public string GetType(int id)
        {
            // Hack
            var book = _context.LibraryAssets
                .OfType<Book>().SingleOrDefault(a => a.Id == id);
            return book != null ? "Book" : "Video";
        }

        private string GetAuthor(int id)
        {
            var book = (Book)Get(id);
            return book.Author;
        }

        private string GetDirector(int id)
        {
            var video = (Video)Get(id);
            return video.Director;
        }
    }
}
