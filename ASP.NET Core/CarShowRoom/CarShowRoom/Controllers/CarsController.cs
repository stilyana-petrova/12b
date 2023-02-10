﻿using CarShowRoom.Data;
using CarShowRoom.Entities;
using CarShowRoom.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShowRoom.Controllers
{
    public class CarsController : Controller
    {
        private readonly ApplicationDbContext context;
        public CarsController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CarCreateViewModel bindingModel)
        {
            if (ModelState.IsValid)
            {
                Car carFromDb = new Car
                {
                    RegNumber = bindingModel.RegNumber,
                    Manufacturer = bindingModel.Manufacturer,
                    Model = bindingModel.Model,
                    Picture = bindingModel.Picture,
                    YearOfManufacture = bindingModel.YearOfManufacture,
                    Price = bindingModel.Price,
                };
                context.Cars.Add(carFromDb);
                context.SaveChanges();
                return this.RedirectToAction("Success");
            }
            return this.View();
        }
        public IActionResult Success()
        {
            return this.View();
        }
        public IActionResult All(string searchStringModel, string searchCarPrice)
        {
            List<CarAllViewModel> cars = context.Cars.Select(carsFromDb => new CarAllViewModel
            {
                Id = carsFromDb.Id,
                RegNumber=carsFromDb.RegNumber,
                Manufacturer=carsFromDb.Manufacturer,
                Model=carsFromDb.Model,
                Picture=carsFromDb.Picture,
                YearOfManufacture=carsFromDb.YearOfManufacture,
                Price=carsFromDb.Price,
                
            }).ToList();

            if (!String.IsNullOrEmpty(searchStringModel) && !String.IsNullOrEmpty(searchCarPrice))
            {
                cars = cars.Where(c => c.Model.ToLower() == searchStringModel.ToLower() && c.Price == double.Parse(searchCarPrice)).ToList();
            }

            else if (!String.IsNullOrEmpty(searchStringModel))
            {
                cars = cars.Where(c => c.Model.ToLower() == searchStringModel.ToLower()).ToList();
            }
            else if (!String.IsNullOrEmpty(searchCarPrice))
            {
                cars = cars.Where(c => c.Price == double.Parse(searchCarPrice)).ToList();
            }
            return View(cars);
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Car item = context.Cars.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            CarEditViewModel dog = new CarEditViewModel()
            {
                Id = item.Id,
                RegNumber = item.RegNumber,
                Manufacturer = item.Manufacturer,
                Model = item.Model,
                Picture = item.Picture,
                YearOfManufacture = item.YearOfManufacture,
                Price = item.Price,
            };
            return View(dog);
        }
        [HttpPost]
        public IActionResult Edit(CarEditViewModel bindingModel)
        {
            if (ModelState.IsValid)
            {
                Car car = new Car()
                {
                    Id = bindingModel.Id,
                    RegNumber = bindingModel.RegNumber,
                    Manufacturer = bindingModel.Manufacturer,
                    Model = bindingModel.Model,
                    Picture = bindingModel.Picture,
                    YearOfManufacture = bindingModel.YearOfManufacture,
                    Price = bindingModel.Price,
                };
                context.Cars.Update(car);
                context.SaveChanges();
                return this.RedirectToAction("All");
            }
            return View(bindingModel);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Car item = context.Cars.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            CarDeleteViewModel car = new CarDeleteViewModel()
            {
                Id = item.Id,
                RegNumber = item.RegNumber,
                Manufacturer = item.Manufacturer,
                Model = item.Model,
                Picture = item.Picture,
                YearOfManufacture = item.YearOfManufacture,
                Price = item.Price,
            };
            return View(car);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            Car item = context.Cars.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            context.Cars.Remove(item);
            context.SaveChanges();
            return this.RedirectToAction("All", "Cars");
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Car item = context.Cars.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            CarDeteilsViewModel car = new CarDeteilsViewModel()
            {
                Id = item.Id,
                RegNumber = item.RegNumber,
                Manufacturer = item.Manufacturer,
                Model = item.Model,
                Picture = item.Picture,
                YearOfManufacture = item.YearOfManufacture,
                Price = item.Price,
            };
            return View(car);
        }
        public IActionResult Sort()
        {  
            List<CarAllViewModel> cars = context.Cars.Select(carFromDb => new CarAllViewModel
            {

                Id = carFromDb.Id,
                RegNumber = carFromDb.RegNumber,
                Manufacturer = carFromDb.Manufacturer,
                Model = carFromDb.Model,
                Picture = carFromDb.Picture,
                YearOfManufacture = carFromDb.YearOfManufacture,
                Price = carFromDb.Price,
            }).OrderBy(x => x.Price).ToList();
     
            return View(cars);
        }
    }
}
