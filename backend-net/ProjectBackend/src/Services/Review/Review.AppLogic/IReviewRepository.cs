using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review.AppLogic
{
    public interface IReviewRepository
    {
        void AddReview(int relableItemId, Domain.Review review);
    }
}
