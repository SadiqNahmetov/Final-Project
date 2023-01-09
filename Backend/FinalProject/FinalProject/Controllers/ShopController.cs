﻿using FinalProject.Data;
using FinalProject.Models;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;

        public ShopController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int? id)
        {
            List<Product> products = await _context.Products
               .Where(m => !m.IsDeleted)
               .Include(m => m.ProductImages)
               .Include(m => m.Brand)
               .Include(m => m.Category)
               .OrderByDescending(m => m.Id)
               .ToListAsync();


            IEnumerable<Category> categories = await _context.Categories
               .Where(m => !m.IsDeleted)
               .ToListAsync();

            IEnumerable<Brand> brands = await _context.Brands.Where(m => !m.IsDeleted).ToListAsync();
            IEnumerable<Size> sizes = await _context.Sizes.Where(m => !m.IsDeleted).ToListAsync();



            ShopVM shopVM = new ShopVM 
            { 
                Product = products,
                Categories = categories,
                Brands = brands,
                Sizes = sizes,
            };

            return View(shopVM);
        }

        public IActionResult Search(string search)
        {
            List<Product> searchName = _context.Products.Where(s => !s.IsDeleted && s.Name.Trim().Contains(search.Trim())).Include(m => m.ProductImages).ToList();
            return PartialView("_Search", searchName);
        }
    }
}
