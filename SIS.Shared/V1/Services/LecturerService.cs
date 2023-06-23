using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SIS.Shared.Exceptions;
using SIS.Shared.V1.Repositories;

namespace SIS.Shared.V1.Services
{
    public interface ILecturerService
    {
        Task<byte[]> GetPhoto(int lecturerId);
    }

    public class LecturerService : ILecturerService
    {
        private readonly ILecturerPhotoRepository _lecturerPhotoRepository;
        private readonly ILecturerRepository _lecturerRepository;

        public LecturerService(ILecturerPhotoRepository lecturerPhotoRepository, ILecturerRepository lecturerRepository)
        {
            _lecturerPhotoRepository = lecturerPhotoRepository;
            _lecturerRepository = lecturerRepository;
        }

        public async Task<byte[]> GetPhoto(int lecturerId)
        {
            var entity = await _lecturerRepository.Query().FirstOrDefaultAsync(x => x.Lecturerid == lecturerId);
            if (entity == null)
            {
                throw new CustomException("Lecturer not found.");
            }
            var photo = await _lecturerPhotoRepository.Query().FirstOrDefaultAsync(x => x.Staffid == entity.Staffid);

            return photo == null ? null : photo.Photo;
        }
    }
}
