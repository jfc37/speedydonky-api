using ActionHandlers.CreateHandlers;
using Actions;
using Common;
using Data.Repositories;
using Models;

namespace ActionHandlers.UpdateHandlers
{
    public class UpdateEntityHandler<TAction, TEntity> : CrudEntityHandler<TAction, TEntity> where TAction : ICrudAction<TEntity> where TEntity : IEntity
    {
        private readonly IRepository<TEntity> _repository;
        private readonly ICommonInterfaceCloner _cloner;

        public UpdateEntityHandler(IRepository<TEntity> repository, ICommonInterfaceCloner cloner)
        {
            _repository = repository;
            _cloner = cloner;
        }

        protected override TEntity PerformAction(TAction action)
        {
            var originalEntity = _repository.Get(action.ActionAgainst.Id);
            _cloner.Copy(action.ActionAgainst, originalEntity);
            return _repository.Update(originalEntity);
        }
    }
}