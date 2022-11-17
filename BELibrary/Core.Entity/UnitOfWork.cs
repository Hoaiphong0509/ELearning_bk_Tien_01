﻿using BELibrary.Core.Entity.Repositories;
using BELibrary.DbContext;
using BELibrary.Persistence.Repositories;

namespace BELibrary.Core.Entity
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ELearningDbContext _context;

        public UnitOfWork(ELearningDbContext context)
        {
            _context = context;
            Account = new AccountRepository(_context);
            Comments = new CommentRepository(_context);
            Courses = new CourseRepository(_context);
            // CourseSubject = new CourseSubjectRepository(_context);
            Documents = new DocumentRepository(_context);
            Lectures = new LectureRepository(_context);
            Rating = new RatingRepository(_context);
            Role = new RoleRepository(_context);
            StudentSubjects = new StudentSubjectRepository(_context);
            StudentTests = new StudentTestRepository(_context);
            Subjects = new SubjectRepository(_context);
            TeacherSubjects = new TeacherSubjectRepository(_context);
            Articles = new ArticleRepository(_context);
            TeacherProfiles = new TeacherProfileRepository(_context);
            Galleries = new GalleryRepository(_context);
        }

        public ICommentRepository Comments { get; private set; }
        public ICourseRepository Courses { get; private set; }

        // public ICourseSubjectRepository CourseSubject { get; private set; }
        public IDocumentRepository Documents { get; private set; }

        public ILectureRepository Lectures { get; private set; }
        public IRatingRepository Rating { get; private set; }
        public IRoleRepository Role { get; private set; }
        public IStudentSubjectRepository StudentSubjects { get; private set; }
        public IStudentTestRepository StudentTests { get; private set; }
        public ISubjectRepository Subjects { get; private set; }
        public ITeacherSubjectRepository TeacherSubjects { get; private set; }

        public IAccountRepository Account { get; private set; }
        public IArticleRepository Articles { get; private set; }
        public ITeacherProfileRepository TeacherProfiles { get; private set; }
        public IGalleryRepository Galleries { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}