using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Note.Models;
using System.Data.Entity.Migrations;


namespace Note.Controllers
{
    public class NoteContentControllers
    {
        public static int getIDfromDB()
        {
            using (var _context = new DBNoteContentEntities())
            {
                var id = (from t in _context.ContentNotes
                         // where ContentNote
                          select t.ID).ToList();
                if (id.Count <= 0)
                {
                    return 1;
                }
                else
                {
                    int i = 1;
                    foreach (int ids in id)
                    {
                        if (ids != i)
                            return i;
                        i++;
                    }
                    return id.Max() + 1;
                }

            }
        }
        public static List<int> getListIDfromDB()
        {
            using (var _context = new DBNoteContentEntities())
            {
                var id = (from t in _context.ContentNotes
                              // where ContentNote
                          select t.ID).ToList();
                return id;
            }
        }
        public static List<ContentNote> getAllNote()
        {
            using (var _context = new DBNoteContentEntities())
            {
                var notes = (from u in _context.ContentNotes.AsEnumerable()
                           //  where u.User_k == _user// tìm giùm t cách load lên còn lại t đg coi lại khóa với lưu định dạng
                             select new//u).ToList;
                             {
                                 ID = u.ID,
                                 title = u.Title,
                                 note = u.NoteContent,
                               //  user = u.User_k
                             })
                             .Select(x => new ContentNote
                             {
                                 ID = x.ID,
                                 Title = x.title,
                                 NoteContent = x.note,
                               //  User_k = x.user
                             });
                return notes.ToList();
            }
        }
        public static void AddNote(ContentNote note)
        {
            using (var _context = new DBNoteContentEntities())
            {
                    _context.ContentNotes.Add(note);
                    _context.SaveChanges(); 
            }
        }
        public static void xoaNote(int id)
        {
            using(var _context=new DBNoteContentEntities())
            {
                ContentNote Note = (from u in _context.ContentNotes
                                    where id == u.ID
                                    select u).SingleOrDefault();
                _context.ContentNotes.Remove(Note);
                _context.SaveChanges();
            }    
        }
        public static void suaNote (int id,string title, string NoteContent)
        {
            using (var _context = new DBNoteContentEntities())
            {
                ContentNote Note = (from u in _context.ContentNotes
                                    where id == u.ID
                                    select u).SingleOrDefault();
                ContentNote note = new ContentNote();
                note.ID = id;
                note.Title = title;
                note.NoteContent = NoteContent;
                _context.ContentNotes.Remove(Note);
                _context.ContentNotes.Add(note);
                _context.SaveChanges();
            }

        }
    }
}
