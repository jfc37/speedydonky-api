﻿using System.Collections.Generic;
using Common.Tests.Builders.MockBuilders;
using Data.Repositories;
using Models;
using Moq;

namespace Data.Tests.Builders
{
    public class MockRepositoryBuilder<T> : MockBuilder<IRepository<T>> where T : IEntity, new()
    {
        public T CreatedEntity { get; set; }
        public T UpdatedEntity { get; set; }

        public MockRepositoryBuilder<T> WithCreate()
        {
            Mock.Setup(x => x.Create(It.IsAny<T>()))
                .Returns<T>(x => x)
                .Callback<T>(x => CreatedEntity = x);

            return this;
        }

        public MockRepositoryBuilder<T> WithUpdate()
        {
            Mock.Setup(x => x.Update(It.IsAny<T>()))
                .Returns<T>(x => x)
                .Callback<T>(x => UpdatedEntity = x);

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

        public MockRepositoryBuilder<T> WithGetAll()
        {
            Mock.Setup(x => x.GetAll())
                .Returns(new List<T>());
            return this;
        }

        public MockRepositoryBuilder<T> WithGetAll(IEnumerable<T> entities)
        {
            Mock.Setup(x => x.GetAll())
                .Returns(entities);
            return this;
        }
    }
}