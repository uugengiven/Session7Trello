using Session7Trello.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Session7Trello.Controllers
{
    public class CardsController : Controller
    {
        // GET: Cards
        public ActionResult Index()
        {
            NoteDbContext notesdb = new NoteDbContext();
            var darnita = notesdb.Categories.ToList();
            ViewBag.Categories = darnita;
            var blake = notesdb.Categories.ToList();
            return View(blake);
        }

        public ActionResult Create(string Title, string Text, int Category)
        {
            NoteDbContext notesdb = new NoteDbContext();
            Note silence = new Note();
            silence.Title = Title;
            silence.Text = Text;
            silence.Category = notesdb.Categories.Find(Category);
            notesdb.Notes.Add(silence);
            notesdb.SaveChanges();

            return View();
        }
    }
}