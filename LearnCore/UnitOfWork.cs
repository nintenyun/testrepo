using LearnCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnCore
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        #region 数据上下文

        /// <summary>
        /// 数据上下文
        /// </summary>
        private ApplicationDbContext _Context;
        public UnitOfWork(ApplicationDbContext Context)
        {
            _Context = Context;
        }

        #endregion

        public bool Commit()
        {
            return _Context.SaveChanges() > 0;
        }

        public void Dispose()
        {
            if (_Context != null)
            {
                _Context.Dispose();
            }
            GC.SuppressFinalize(this);
        }
    }
}
