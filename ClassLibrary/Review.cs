using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Review
    {
        private int _reviewId;
        private string _reviewText;
        private int _upvotes;
        private int _moduleId;
        private int _studentId;

        public Review(int pReviewId, string pReviewText, int pUpvotes, int pStudentId, int pModuleId)
        {
            _reviewId = pReviewId;
            _reviewText = pReviewText;
            _upvotes = pUpvotes;
            _studentId = pStudentId;
            _moduleId = pModuleId;
        }

        public int GetReviewId()
        {
            return _reviewId;
        }

        public int GetStudentId()
        {
            return _studentId;
        }

        public string GetReviewText()
        {
            return _reviewText;
        }

        public int GetUpvotes()
        {
            return _upvotes;
        }

    }
}
