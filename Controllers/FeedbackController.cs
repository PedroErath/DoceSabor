using DoceSabor.Models;
using Microsoft.AspNetCore.Mvc;


namespace DoceSabor.Controllers
{
    public class FeedbackController : Controller
    {
        public IActionResult ListaFeedback(string n)
        {
            FeedbackService service = new FeedbackService();

            if(n == null)
                n = string.Empty;
            
            return View(service.GetFeedbacks(n));
        }

        public IActionResult Excluir(int id)
        {
            FeedbackService service = new FeedbackService();
            Feedback fb = service.GetFeedbackDetail(id);

            return View(fb);
        }
        [HttpPost]
        public IActionResult Excluir(int id, string decisao)
        {
            if(decisao == "s")
            {
                FeedbackService service = new FeedbackService();
                service.DeleteFeedback(id);
            }

            return RedirectToAction("ListaFeedback");
        }
    }
}