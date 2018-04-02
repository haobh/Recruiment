using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMC.Data.Infrastructure;
using UMC.Data.Repositories;
using UMC.Model.Models;

namespace UMC.Service
{
    public interface IRecruimentService
    {
        Task<IEnumerable<RecruimentInfor>> GetAll();
        Task<IEnumerable<RecruimentInfor>> GetAll(string keyword);
        Task<RecruimentInfor> Add(RecruimentInfor recruiment);
        Task Update(RecruimentInfor recruiment);
        Task<RecruimentInfor> GetById(int id);
        Task<RecruimentInfor> Delete(int id);
        Task SaveAsync();
    }
    public class RecruimentService : IRecruimentService
    {
        private readonly IRecruimentRepository _recruimentRepository;
        private readonly IUnitOfWork _unitOfWork;
        public RecruimentService(IRecruimentRepository recruimentRepository, IUnitOfWork unitOfWork)
        {
            this._recruimentRepository = recruimentRepository;
            this._unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<RecruimentInfor>> GetAll()
        {
            return await _recruimentRepository.GetAll();
        }
        //Nếu có keyword thì vào hàm tìm kiếm, không thì nó vào hàm trên
        public async Task<IEnumerable<RecruimentInfor>> GetAll(string keyword)
        {
            if (!string.IsNullOrEmpty(keyword))
                return await _recruimentRepository.GetMulti(x => x.Name.Contains(keyword) || x.Department.Contains(keyword));
            else
                return await _recruimentRepository.GetAll();
        }
        public async Task<RecruimentInfor> Add(RecruimentInfor recruiment)
        {
            return await Task.FromResult(_recruimentRepository.Add(recruiment));
        }
        public async Task Update(RecruimentInfor recruiment)
        {
            await Task.FromResult<object>(null);
            _recruimentRepository.Update(recruiment);
        }
        public async Task<RecruimentInfor> GetById(int id)
        {
            return await Task.FromResult(_recruimentRepository.GetSingleById(id));
        }
        public async Task<RecruimentInfor> Delete(int id)
        {
            return await Task.FromResult(_recruimentRepository.Delete(id));
        }
        public async Task SaveAsync()
        {
            await _unitOfWork.CommitAsync();
        }
    }
}
