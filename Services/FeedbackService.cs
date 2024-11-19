using FeedbackApp.Data;
using Microsoft.EntityFrameworkCore;

namespace FeedbackApp.Services
{
    public class FeedbackService : IFeedbackService
    {
        private readonly ApplicationDbContext _context;

        public FeedbackService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<FeedbackMessage>> GetFeedbackMessageList()
        {
            return await _context.FeedbackMessages.ToListAsync();                          
        }

        public async Task<FeedbackMessage> GetFeedbackMessageById(int id)
        {
            return await _context.FeedbackMessages               
                  .FirstOrDefaultAsync(x => x.Id == id) ?? new FeedbackMessage();
        }

        public async Task<FeedbackMessage> CreateFeedbackMessage(FeedbackMessage feedbackMessage)
        {
            _context.FeedbackMessages.Add(feedbackMessage);
            await _context.SaveChangesAsync();
            return feedbackMessage;
        }

        public async Task UpdateFeedback(FeedbackMessage feedbackMessage)
        {
            _context.FeedbackMessages.Update(feedbackMessage);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteFeedback(FeedbackMessage feedbackMessage)
        {
            _context.FeedbackMessages.Remove(feedbackMessage);
            await _context.SaveChangesAsync();
        }
       
    }
}
