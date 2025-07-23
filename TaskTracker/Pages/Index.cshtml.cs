using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TaskTracker.Data;
using TaskTracker.Models;

namespace TaskTracker.Pages.Tasks;

public class IndexModel : PageModel
{
    private readonly AppDBContext _context;
    public List<TaskEntryDB> Tasks { get; set; } = new();

    [BindProperty]
    public string Title { get; set; }
    [BindProperty]
    public string Description { get; set; }

    public IndexModel(AppDBContext context)
    {
        _context = context;
    }

    public void OnGet()
    {
        Tasks = _context.Tasks.ToList();
    }

    public IActionResult OnPost()
    {
        if (!string.IsNullOrWhiteSpace(Title))
        {
            _context.Tasks.Add(new TaskEntryDB { Title = Title, Description = Description, IsCompleted = false });
            _context.SaveChanges();
        }
        return RedirectToPage();
    }

    public IActionResult OnPostToggle(int id)
    {
        var task = _context.Tasks.Find(id);
        if (task != null)
        {
            task.IsCompleted = !task.IsCompleted;
            _context.SaveChanges();
        }
        return RedirectToPage();
    }

    public IActionResult OnPostDeleteCompleted()
    {
        var completedTasks = _context.Tasks.Where(t => t.IsCompleted).ToList();
        foreach (var completedTask in completedTasks)
        {
            _context.Tasks.Remove(completedTask);
        }
        _context.SaveChanges();
        return RedirectToPage();
    }
}
