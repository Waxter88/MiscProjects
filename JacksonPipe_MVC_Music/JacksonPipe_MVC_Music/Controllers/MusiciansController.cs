using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JacksonPipe_MVC_Music.Data;
using JacksonPipe_MVC_Music.Models;
using JacksonPipe_MVC_Music.ViewModels;
using Microsoft.EntityFrameworkCore.Storage;

namespace JacksonPipe_MVC_Music.Controllers
{
    public class MusiciansController : Controller
    {
        private readonly MusicContext _context;

        public MusiciansController(MusicContext context)
        {
            _context = context;
        }

        // GET: Musicians
        public async Task<IActionResult> Index()
        {
            Musician musician = new Musician();
            PopulateAssignedInstrumentData(musician);
            UpdateDropDownLists();

            var musicians = _context.Musicians
                .Include(m => m.Play).ThenInclude(p => p.Instrument);
            return View(await _context.Musicians.ToListAsync());
        }

        // GET: Musicians/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Musicians == null)
            {
                return NotFound();
            }

            var musician = await _context.Musicians
                .FirstOrDefaultAsync(m => m.ID == id);
            
            if (musician == null)
            {
               return NotFound();
            }
            PopulateAssignedInstrumentData(musician);
            UpdateDropDownLists();
            return View(musician);
        }

        // GET: Musicians/Create
        public IActionResult Create()
        {
            //add unchecked instruments to viewbag
            var musician = new Musician();
            PopulateAssignedInstrumentData(musician);
            UpdateDropDownLists();

            return View();
        }

        // POST: Musicians/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,FirstName,MiddleName,LastName,Phone,DOB,SIN,InstrumentID,Instrument")] Musician musician, string[] selectedOptions)
        {
            try
            {
                //add options
                if (selectedOptions != null)
                {
                    foreach (var instrument in selectedOptions)
                    {
                        var instrumentToAdd = new Play { MusicianID = musician.ID, InstrumentID = int.Parse(instrument) };
                        musician.Play.Add(instrumentToAdd);
                    }
                }
                if (ModelState.IsValid)
                {
                    _context.Add(musician);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (RetryLimitExceededException)
            {
                ModelState.AddModelError("", "Unable to save changes after multiple attemps. Try again.");
            }
            catch (DbUpdateException dex)
            {
                if (dex.InnerException.Message.Contains("IX_Musicians_SIN"))
                {
                    ModelState.AddModelError("SIN", "Unable to save changes. " + "Try again, and if the problem persists " + "see your system administrator.");
                }
                else
                {
                    ModelState.AddModelError("", "Unable to save changes. " + "Try again, and if the problem persists, " + "see your system administrator.");
                }
            }

            //ViewData["InstrumentID"] = new SelectList(_context.Instruments, "ID", "Name", musician.InstrumentID);
            PopulateAssignedInstrumentData(musician);
            UpdateDropDownLists(musician);
            return View(musician);
        }

        // GET: Musicians/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Musicians == null)
            {
                return NotFound();
            }

            var musician = await _context.Musicians
                .Include(i => i.Play)
                .ThenInclude(i => i.Instrument)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (musician == null)
            {
                return NotFound();
            }
            //ViewData["InstrumentID"] = new SelectList(_context.Instruments, "ID", "Name", musician.InstrumentID);
           
            PopulateAssignedInstrumentData(musician);
            UpdateDropDownLists(musician);
            return View(musician);
        }

        // POST: Musicians/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, string[] selectedOptions)
        {
            var musicianToUpdate = await _context.Musicians
                .Include(i => i.Play).ThenInclude(i => i.Instrument)
                .FirstOrDefaultAsync(m => m.ID == id);

            if (musicianToUpdate == null)
            {
                return NotFound();
            }

            //update the musician's instrument list
            UpdateMusicianInstruments(selectedOptions, musicianToUpdate);
            

            if (await TryUpdateModelAsync<Musician>(musicianToUpdate, "", m => m.FirstName, m => m.LastName, m=> m.MiddleName, m => m.Phone, m => m.SIN, m => m.DOB, m => m.Play, m=> m.InstrumentID, m=> m.Instrument))
            {
                try
                {
                     //_context.Update(musicianToUpdate);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Details", new { musicianToUpdate.ID });
                }
                catch (RetryLimitExceededException)
                {
                    ModelState.AddModelError("", "Unable to save changes after multiple attemps. Try again"); 
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MusicianExists(musicianToUpdate.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                catch (DbUpdateException dex)
                {
                    if (dex.InnerException.Message.Contains("IX_Musicians_SIN"))
                    {
                        ModelState.AddModelError("SIN", "Unable to save changes. " + "Try again, and if the problem persists " + "see your system administrator.");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Unable to save changes. " + "Try again, and if the problem persists, " + "see your system administrator.");
                    }
                }
                //return RedirectToAction(nameof(Index));
            }
            //ViewData["InstrumentID"] = new SelectList(_context.Instruments, "ID", "Name", musician.InstrumentID);
            PopulateAssignedInstrumentData(musicianToUpdate);
            UpdateDropDownLists(musicianToUpdate);
            return View(musicianToUpdate);
        }

        // GET: Musicians/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Musicians == null)
            {
                return NotFound();
            }

            var musician = await _context.Musicians
                .Include(m => m.InstrumentID)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (musician == null)
            {
                return NotFound();
            }

            return View(musician);
        }

        // POST: Musicians/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Musicians == null)
            {
                return Problem("Entity set 'MusicContext.Musicians'  is null.");
            }
            var musician = await _context.Musicians.FindAsync(id);
            if (musician != null)
            {
                _context.Musicians.Remove(musician);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        
        //Populate instrument data checkbox
        private void PopulateAssignedInstrumentData(Musician musician)
        {
            var allOptions = _context.Instruments;
            var currentOptionIDs = new HashSet<int>(musician.Play.Select(c => c.InstrumentID));
            var checkBoxes = new List<CheckOption>();
            foreach (var option in allOptions)
            {
                checkBoxes.Add(new CheckOption
                {
                    ID = option.ID,
                    DisplayText = option.Name,
                    Assigned = currentOptionIDs.Contains(option.ID)
                });
                ViewData["Play"] = checkBoxes;
            }
        }

        //update musician instruments
        private void UpdateMusicianInstruments(string[] selectedOptions, Musician musicianToUpdate)
        {
            if (selectedOptions == null)
            {
                musicianToUpdate.Play = new List<Play>();
                return;
            }
            
            var selectedOptionsHS = new HashSet<string>(selectedOptions);
            var musicianOptions = new HashSet<int>
                (musicianToUpdate.Play.Select(c => c.InstrumentID));//IDs of selected Instruments
            foreach (var option in _context.Instruments)
            {
                if (selectedOptionsHS.Contains(option.ID.ToString()))//checked
                {
                    if (!musicianOptions.Contains(option.ID))//not in history
                    {
                        musicianToUpdate.Play.Add(new Play { MusicianID = musicianToUpdate.ID, InstrumentID = option.ID });
                    }
                }
                else//checkbox not checked
                {  
                   if (musicianOptions.Contains(option.ID))//in history
                   {
                        Play optionToRemove = musicianToUpdate.Play.SingleOrDefault(i => i.InstrumentID == option.ID);
                        _context.Remove(optionToRemove);
                   }
                }
            }
        }
        private void UpdateDropDownLists(Musician musician = null)
        {
            ViewData["InstrumentID"] = new SelectList(_context.Instruments, "ID", "Name", musician?.InstrumentID);
        }
        private bool MusicianExists(int id)
        {
            return _context.Musicians.Any(e => e.ID == id);
        }
    }
}
