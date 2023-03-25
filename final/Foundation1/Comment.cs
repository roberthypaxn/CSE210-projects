using System;

class Comment
    {
        private string _nameOfUser;
        private string _commentText;
        public string _fullComment;
        public Comment()
        {}
        public Comment(string nameOfUser, string comment)
        {
            _nameOfUser = nameOfUser;
            _commentText = comment;
            _fullComment = $"{_nameOfUser}: \n{_commentText}";
        }
    }