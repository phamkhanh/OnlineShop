using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Service
{
    //[TestClass]
    //class PostCategoryRepositoryTest
    //{
    //    IDbFactory _dbFactory;
    //    IPostCategoryRepository _postCategoryRepository;
    //    IUnitOfWork _unitOfWork;

    //    [TestInitialize]
    //    public void Initialize()
    //    {
    //        _dbFactory = new DbFactory();
    //        _postCategoryRepository = new PostCategoryRepository(_dbFactory);
    //        _unitOfWork = new UnitOfWork(_dbFactory);
    //    }

    //    [TestMethod]
    //    public void PostCategory_Repository_Create()
    //    {
    //        PostCategory postCategory = new PostCategory();
    //        postCategory.Name = "Test category";
    //        postCategory.Alias = "Test-category";
    //        postCategory.Status = true;
    //        var result = _postCategoryRepository.Add(postCategory);
    //        _unitOfWork.Commit();

    //        Assert.IsNotNull(result);
    //        Assert.AreEqual(1, result.ID);
    //    }
    //}
}
