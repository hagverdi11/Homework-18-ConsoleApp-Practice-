using Domain.Models;
using Repository.Repostories;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class LibraryServices : ILibraryServices
    {

        private LibraryRepository _libraryRepository;
        private int _count;
        public LibraryServices()
        {
            _libraryRepository = new LibraryRepository();
        }
        public Library Create(Library library)
        {
            library.Id = _count;
            _libraryRepository.Create(library);
            _count++;
            return library;

        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Library> GetAll()
        {
            throw new NotImplementedException();
        }

        public Library GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Library Update(int id, Library library)
        {
            throw new NotImplementedException();
        }
    }
}
