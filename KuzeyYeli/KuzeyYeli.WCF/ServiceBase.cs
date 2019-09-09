using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KuzeyYeli.WCF
{
    using DTO;
    using Entity;
    using Repository;
    using Extensions;
    public class ServiceBase<Rep, Entity, DTO> : IService<DTO>
        where DTO : class
        where Entity : class
        where Rep : RepositoryBase<Entity>
    {
        private Rep repository;
        //Activator sınıfı içerisindeki CreateInstance isimli generic method; içerisine verilen Generic tipten instance üretmeyi sağlar
        public Rep Repository
        {
            get
            {
                repository = repository ?? Activator.CreateInstance<Rep>();
                return repository;
            }
            set { repository = value; }
        }

        public List<DTO> Listele()
        {
            return Repository.Listele().Select(x => x.Changer<DTO>()).ToList();
        }

        public bool Ekle(DTO dto)
        {
            return Repository.Ekle(dto.Changer<Entity>());
        }

        public bool Guncelle(DTO dto)
        {
            return Repository.Guncelle(dto.Changer<Entity>());
        }

        public bool Sil(DTO dto)
        {
            return Repository.Sil(dto.Changer<Entity>());
        }
    }
}