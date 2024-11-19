using FeedbackApp.Data;

namespace FeedbackApp.Services
{   
  public interface IFeedbackService
    {
        Task<List<FeedbackMessage>> GetFeedbackMessageList();
        Task<FeedbackMessage> GetFeedbackMessageById(int id);
        Task<FeedbackMessage> CreateFeedbackMessage(FeedbackMessage feedbackMessage);
        Task UpdateFeedback(FeedbackMessage feedbackMessage);
        Task DeleteFeedback(FeedbackMessage feedbackMessage);
    }
}
