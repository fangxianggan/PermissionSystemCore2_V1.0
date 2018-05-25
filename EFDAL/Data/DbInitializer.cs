using EFEntity.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace EFDAL.Data
{
    public class DbInitializer
    {
        /// <summary>
        /// 初始化数据
        /// </summary>
        public static void Initializer(PerDbContext context)
        {
            //检查是否有用户信息
            if (context.User.Any())
            {
                return; //存在不执行
            }


            #region 角色

            Role role = new Role() { RoleCode = "admin", RoleName = "管理员" };
            context.Role.Add(role);

            #endregion


            #region 添加组织机构/部门

            Department dept = new Department() { DeptCode = "FXKJ", DeptName = "方向科技" };
            context.Department.Add(dept);

            #endregion


            Collection<Role> roleList = new Collection<Role>();
            roleList.Add(role);

            #region 添加管理员信息

            User user = new User() { UserName = "杨向东", LoginName = "yxd", Password = "123", DeptId = dept.Id , GetRoles=roleList };
            context.User.Add(user);

            context.SaveChanges();
            #endregion




        }
    }
}
