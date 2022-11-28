using Review.AppLogic;
using Review.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review.Infrastructure
{
    internal class ReviewRespository : IReviewRepository
    {
        private ReviewDbContext _reviewDbContext { get; set; }

        public ReviewRespository(ReviewDbContext reviewDbContext)
        {
            _reviewDbContext = reviewDbContext;
        }
        public void AddReview(int relableItemId, Domain.Review review)
        {
            RatableItem ratableItem = _reviewDbContext.retableItems.Find(relableItemId);
            ratableItem.Reviews.Add(review);
            _reviewDbContext.SaveChangesAsync();
        }
    }
}
