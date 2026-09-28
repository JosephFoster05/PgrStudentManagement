using Microsoft.AspNetCore.Mvc;
using PgrStudentManagement.Models;

namespace PgrStudentManagement.Controllers;

public class StudentsController : Controller
{
    private static List<Student> Students = new ()
    {
        new Student
        {
            StudentNumber = "S100001",
            FirstName = "John",
            LastName = "Doe",
            Course = "PhD Computing",
            ModeOfStudy = "Full-time",
            StartDate = new DateTime(2025, 10, 1),
            Status = Status.Researching,
            ThesisTitle = "Explainable Models for Clinical Decision Support"
        },
        new Student
        {
            StudentNumber = "S100002",
            FirstName = "Jane",
            LastName = "Smith",
            Course = "Professional Doctorate",
            ModeOfStudy = "Part-time",
            StartDate = new DateTime(2024, 10, 1),
            Status = Status.WritingUp,
            ThesisTitle = null
        }
    };

    public IActionResult Index()
    {
        return View(Students);
    }

    public IActionResult EnrolmentDetails(string studentNumber)
    {
        // TODO W2-UC01:
        // 1. Find the student.
        // 2. Handle Student Not Found.
        // 3. Supply the selected enrolment fields to the view.

        return View();
    }

    public IActionResult ThesisDetails(string studentNumber)
    {
        // TODO W2-UC02:
        // 1. Find the student.
        // 2. Determine whether thesis information is available.
        // 3. Supply the selected thesis fields to the view.

        return View();
    }

    [HttpGet]
    public IActionResult EditStatus(string studentNumber)
    {
        var student = Students.FirstOrDefault(s => s.StudentNumber == studentNumber);
        if (student == null)
        {
            return NotFound();
        }
        return View(student);
    }

    [HttpPost]
    public IActionResult EditStatus(string studentNumber, Status status)
    {

        var student_to_update = Students.FirstOrDefault(s => s.StudentNumber == studentNumber);
        if (student_to_update != null)
        {
            student_to_update.Status = status;
        }

        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult EditExpectedSubmissionDate(string studentNumber)
    {
        // TODO W2-UC04:
        // Find the student and display the existing expected date.

        return View();
    }

    [HttpPost]
    public IActionResult EditExpectedSubmissionDate(string studentNumber,     
            DateTime expectedSubmissionDate)
    {
        // TODO W2-UC04:
        // Validate and update the expected submission date.

        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult RecordSubmission(string studentNumber)
    {
        // TODO W2-UC05:
        // Find the student and display current thesis information.

        return View();
    }

    [HttpPost]
    public IActionResult RecordSubmission(string studentNumber,
        DateTime actualSubmissionDate)
    {
        // TODO W2-UC05:
        // 1. Validate the date.
        // 2. Record the actual submission date.
        // 3. Change the status to Submitted.
        // 4. Ensure that no partial update occurs.

        return RedirectToAction(nameof(Index));
    }
}
