﻿using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Entities.Concrete;
using Core.Utilities.Business.BusinessAspects.Autofac;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Concrete
{
    public class GroupManager : IGroupService
    {

        private readonly FlattyContext _context;
        IGroupDal _groupDal;
        private object filter;

        IUserDal _userDal;
        IBalanceDal _groupUserDal;

        public GroupManager(IGroupDal groupDal) 
        {
            _groupDal = groupDal;
        }

        [SecuredOperation("product.add,admin")]
        [ValidationAspect(typeof(GroupValidator))]
        public IResults AddGroup(Group group)
        {
            _groupDal.Add(group);
            return new SuccessResult(Messages.GroupAddSuccess);
        }

        public IResults DeleteGroup(Group group)
        {
            _groupDal.Delete(group);
            return new SuccessResult(Messages.GroupDeleteSuccess);
        }

        public IDataResult<List<Group>> GetAll()
        {
            if (DateTime.Now.Hour == 24)
            {
                return new FailDataResult<List<Group>>();
            }
            return new SuccessDataResult<List<Group>>(_groupDal.GetAll(),Messages.GroupListedSuccess);   
        }

        public IDataResult<List<User>> GetAll(int groupId)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(gu => gu.Id == groupId));
        }

        

        public IDataResult<List<Group>> GetByGroupName(string groupName)
        {
            return new SuccessDataResult<List<Group>>(_groupDal.GetAll(n => n.Name == groupName),Messages.GroupListedSuccess);
        }

        public IDataResult<Group> GetById(int groupId)
        {
            return new SuccessDataResult<Group>(_groupDal.Get(g=>g.Id==groupId));
        }

        public IDataResult<List<Balance>> GetList()
        {
            throw new NotImplementedException();
        }

        public int GetMemberCount(int groupId)
        {
            int memberCount = _context.Groups.Count(gu => gu.Id == groupId);

            return memberCount;
        }

        public IDataResult<List<User>> GetMembers(int groupId)
        {
            var group = _groupDal.Get(g=>g.Id==groupId);
            var users = new List<User>();


            return new SuccessDataResult<List<User>>(users);
        }

        [ValidationAspect(typeof(GroupValidator))]
        //[CacheRemoveAspect("IProductService.Get")]
        public IResults UpdateGroup(Group group)
        {
            var result = _groupDal.GetAll(p => p.Id == group.Id).Count;
            if (result >= 10)
            {
                return new FailureResult("A group count error occured. ");
            }
            throw new NotImplementedException();
        }

        
    }
}
