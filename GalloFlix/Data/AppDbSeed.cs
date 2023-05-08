using GalloFlix.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace GalloFlix.Data;

    public class AppDbSeed
    {
        
        public AppDbSeed(ModelBuilder builder)
        {

            #region Populate Roles - Perfis de Usuário
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
    
            #endregion

            #region Popular AppUser - Usuários
            List<AppUser> users = new(){
                    new AppUser(){
                        Id = Guid.NewGuid().ToString(),
                        Name = "Joany Camily da Silva" ,
                        DateOfBirth = DateTime.Parse("02/09/2005"),
                        Email = "joanycamily23@gmail.com",
                        NormalizedEmail = "JOANYCAMILY@GMAIL.COM",
                        UserName = "JoanySilva",
                        NormalizedUserName = "JOANYSILVA",
                        LockoutEnabled = false, 
                        PhoneNumber = "14981799095",
                        PhoneNumberConfirmed = true,
                        EmailConfirmed = true,
                        ProfilePicture = "img/users/avatar.png"
                    }
             };
            foreach (var user in users)
            {
                PasswordHasher<AppUser> pass = new();
                user.PasswordHash = pass.HashPassword(user, "@Etec123");
            }
            builder.Entity<AppUser>().HasData(users);
            #endregion
        }

            #region Populate UserRole - Usuarios com Perfil 
            List<IdentityUserRole<string>> userRoles = new ()
            {
                new IdentityUserRole<string>() {
                    UserId = users[0].Id,
                    RoleId = roles[1].Id
                }
            };
            builder.Entity<IdentityUserRole<string>>.HasData(userRoles)
            #endregion
    }
}