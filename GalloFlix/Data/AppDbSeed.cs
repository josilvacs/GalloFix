using GalloFlix.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace GalloFlix.Data;

    public class AppDbSeed
    {
        public AppDbSeed(ModelBuilder builder)
        {
             #region Populate Roles - Perfils de Usuário


             List<IdentityRole> roles = new()
             {
                new IdentityRole()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Administrador",
                    NormalizedName = "ADMINISTRADOR"
                },
                 new IdentityRole()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Moderador",
                    NormalizedName = "MODERADOR"
                },
                 new IdentityRole()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Usuário",
                    NormalizedName = "USUÁRIO"
                }
             };
             builder.Entity<IdentityRole>().HasData(roles);
                #endregion
             
             #region Popular AppUser -Usuários

             List<AppUser> users = new()
             {
                new AppUser(){
                    Id = Guid.NewGuid().ToString(),
                    Name= "Joany Camily da Silva",
                    DateOfBirth = DateTime.Parse("10/03/2006"),
                    Email ="joanycamily23@gmail.com",
                    NormalizedEmail ="JOANYCAMILY23@GMAIL.COM",
                    UserName = "Joany",
                    NormalizedUserName ="JOANY",
                    LockoutEnabled = false,
                    PhoneNumber ="14981799095",
                    PhoneNumberConfirmed= true,
                    EmailConfirmed = true,
                    ProfilePicture= "/img/users/avatar.png"
                }
             };
            foreach (var user in users)
            {
                PasswordHasher<AppUser> pass = new();
                user.PasswordHash = pass.HashPassword(user, "@Etec123");
            }            
            builder.Entity<AppUser>().HasData(users);
               #endregion

            #region Populate UserRole - Usuário com Perfil
            List<IdentityUserRole<string>> userRoles = new()
            {
                new IdentityUserRole<string>(){
                    UserId = users [0].Id,
                    RoleId = roles[0].Id
                }
            };
            builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
            #endregion
        }
    }