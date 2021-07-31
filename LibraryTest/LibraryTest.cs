using Api_library.Controllers;
using Api_library.Models;
using Api_library.Services;
using AutoMapper;
using Library.Db.Entitties;
using Moq;
using System;
using Xunit;

namespace LibraryTest
{
    public class LibraryTest
    {
        private Mock<IUserInfoService> _userInfoServiceMock = new Mock<IUserInfoService>();
        private Mapper _mapper;
        private UsersController _userController;

        public LibraryTest()
        {
            _userInfoServiceMock.Setup(repo => repo.GetUserInfoById(2)).Returns(GetDbUser());
            var mapConfig = new MapperConfiguration(cfg => cfg.CreateMap<DbUser, DtoUser>());
            _mapper = new Mapper(mapConfig);
            _userController = new UsersController(_userInfoServiceMock.Object, _mapper);

        }
        #region Data comparison
        [Fact]
        public void TestEqual()
        {
            var result = _userController.GetUserById("2");
            var mapDtoUser = _mapper.Map<DtoUser>(GetDbUser());

            Assert.Equal(mapDtoUser.FirstName, result.Value.FirstName);
        }
        #endregion

        #region checking that the collection is not 0
        [Fact]
        public void NotNulls()
        {
            var result = _userController.GetUserById("2");
            Assert.NotNull(result);
        }
        #endregion

        #region IsNull
        [Fact]
        public void IsNulls()
        {
            var result = _userController.GetUserById("45435");
            Assert.Null(result);
        }
        #endregion


        #region Data for Testing
        public static DbUser GetDbUser()
        {
            DbUser user = new DbUser()
            {
                Id = 4,
                CreatedAt = DateTime.Now,
                FirstName = "Natalia",
                LastName = "Petrova",
                Email = "fdffg52@mail.ru",
                Avatar = "8edcb48f-0584-4974-9316-c9b2de3d9140.jpeg",
                Gender = UserGender.Woman,
                NumberPhone = 89324567831
            };
            return user;
        }
        #endregion
    }
}
