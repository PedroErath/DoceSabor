using System.Collections.Generic;
using System.Linq;

namespace DoceSabor.Models
{
    public class FeedbackService
    {
        public int CreateFeedback(Feedback novoFb)
        {
            using (var context = new DoceSaborContext())
            {
                context.Add(novoFb);
                context.SaveChanges();
                return novoFb.Id;
            }
        }

        public ICollection<Feedback> GetFeedbacks(string termo)
        {
            using (var context = new DoceSaborContext())
            {
                IQueryable<Feedback> consulta = 
                    context.Feedbacks.Where(f => f.Nome.Contains(termo, System.StringComparison.OrdinalIgnoreCase));

                return consulta.ToList();
            }
        }

        public Feedback GetFeedbackDetail(int id)
        {
            using(var context = new DoceSaborContext())
            {
                Feedback registro = context.Feedbacks.Where(f => f.Id == id).SingleOrDefault();

                return registro;
            }
        }

        public void DeleteFeedback(int id)
        {
            using (var context = new DoceSaborContext())
            {
                Feedback registro = context.Feedbacks.Find(id);
                context.Feedbacks.Remove(registro);
                context.SaveChanges();
            }
        }
    }
}