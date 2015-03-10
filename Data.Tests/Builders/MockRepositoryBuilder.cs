﻿using Common.Tests.Builders.MockBuilders;
using Data.Repositories;
using Models;
using Moq;

namespace Data.Tests.Builders
{
    public class MockRepositoryBuilder<T> : MockBuilder<IRepository<T>> where T : IEntity, new()
    {
        public T CreatedEntity { get; set; }

        public MockRepositoryBuilder<T> WithCreate()
        {
            Mock.Setup(x => x.Create(It.IsAny<T>()))
                .Returns<T>(x => x)
                .Callback<T>(x => CreatedEntity = x);

            return this;
        }

        public MockRepositoryBuilder<T> WithSuccessfulGet()
        {
            Mock.Setup(x => x.GetAll())
                .Returns(new []
                {
                    new T() 
                });
            Mock.Setup(x => x.Get(It.IsAny<int>()))
                .Returns(new T());
            return this;
        }

        public MockRepositoryBuilder<T> WithGet(T entity)
        {
            Mock.Setup(x => x.Get(It.IsAny<int>()))
                .Returns(entity);
            return this;
        }
    }
}