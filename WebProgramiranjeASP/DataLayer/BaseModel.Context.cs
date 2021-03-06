﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebProgramiranjeASP.DataLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class BaseEntities : DbContext
    {
        public BaseEntities()
            : base("name=BaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<aboutme> aboutmes { get; set; }
        public DbSet<comment> comments { get; set; }
        public DbSet<first> firsts { get; set; }
        public DbSet<function> functions { get; set; }
        public DbSet<gallery> galleries { get; set; }
        public DbSet<home> homes { get; set; }
        public DbSet<seventh> sevenths { get; set; }
        public DbSet<six> sixes { get; set; }
        public DbSet<userFunction> userFunctions { get; set; }
        public DbSet<user> users { get; set; }
        public DbSet<navigation> navigations { get; set; }
    
        public virtual int AboutUpdate(Nullable<int> id, string title, string text, string fb, string insta, string plus, string mail)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            var textParameter = text != null ?
                new ObjectParameter("text", text) :
                new ObjectParameter("text", typeof(string));
    
            var fbParameter = fb != null ?
                new ObjectParameter("fb", fb) :
                new ObjectParameter("fb", typeof(string));
    
            var instaParameter = insta != null ?
                new ObjectParameter("insta", insta) :
                new ObjectParameter("insta", typeof(string));
    
            var plusParameter = plus != null ?
                new ObjectParameter("plus", plus) :
                new ObjectParameter("plus", typeof(string));
    
            var mailParameter = mail != null ?
                new ObjectParameter("mail", mail) :
                new ObjectParameter("mail", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AboutUpdate", idParameter, titleParameter, textParameter, fbParameter, instaParameter, plusParameter, mailParameter);
        }
    
        public virtual int CommentDelete(Nullable<int> idComment)
        {
            var idCommentParameter = idComment.HasValue ?
                new ObjectParameter("idComment", idComment) :
                new ObjectParameter("idComment", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CommentDelete", idCommentParameter);
        }
    
        public virtual int FirstUpdate(Nullable<int> id, string title, string text)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            var textParameter = text != null ?
                new ObjectParameter("text", text) :
                new ObjectParameter("text", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("FirstUpdate", idParameter, titleParameter, textParameter);
        }
    
        public virtual int GalleryDelete(Nullable<int> idGallery)
        {
            var idGalleryParameter = idGallery.HasValue ?
                new ObjectParameter("idGallery", idGallery) :
                new ObjectParameter("idGallery", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GalleryDelete", idGalleryParameter);
        }
    
        public virtual int GalleryInsert(string name, string img)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var imgParameter = img != null ?
                new ObjectParameter("img", img) :
                new ObjectParameter("img", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GalleryInsert", nameParameter, imgParameter);
        }
    
        public virtual int GalleryUpdate(Nullable<int> idGallery, string name, string img)
        {
            var idGalleryParameter = idGallery.HasValue ?
                new ObjectParameter("idGallery", idGallery) :
                new ObjectParameter("idGallery", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var imgParameter = img != null ?
                new ObjectParameter("img", img) :
                new ObjectParameter("img", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GalleryUpdate", idGalleryParameter, nameParameter, imgParameter);
        }
    
        public virtual int HomeUpdate(Nullable<int> id, string title, string text)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            var textParameter = text != null ?
                new ObjectParameter("text", text) :
                new ObjectParameter("text", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("HomeUpdate", idParameter, titleParameter, textParameter);
        }
    
        public virtual int SeventhUpdate(Nullable<int> id, string title, string text)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            var textParameter = text != null ?
                new ObjectParameter("text", text) :
                new ObjectParameter("text", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SeventhUpdate", idParameter, titleParameter, textParameter);
        }
    
        public virtual int SixUpdate(Nullable<int> id, string title, string text)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            var textParameter = text != null ?
                new ObjectParameter("text", text) :
                new ObjectParameter("text", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SixUpdate", idParameter, titleParameter, textParameter);
        }
    
        public virtual int UserDelete(Nullable<int> idUser)
        {
            var idUserParameter = idUser.HasValue ?
                new ObjectParameter("idUser", idUser) :
                new ObjectParameter("idUser", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UserDelete", idUserParameter);
        }
    
        public virtual int UserInsert(string user, string password, string mail, Nullable<int> idFunction)
        {
            var userParameter = user != null ?
                new ObjectParameter("user", user) :
                new ObjectParameter("user", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var mailParameter = mail != null ?
                new ObjectParameter("mail", mail) :
                new ObjectParameter("mail", typeof(string));
    
            var idFunctionParameter = idFunction.HasValue ?
                new ObjectParameter("idFunction", idFunction) :
                new ObjectParameter("idFunction", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UserInsert", userParameter, passwordParameter, mailParameter, idFunctionParameter);
        }
    
        public virtual int UserUpdate(Nullable<int> idUser, string user, string password, string mail, Nullable<int> idFunction)
        {
            var idUserParameter = idUser.HasValue ?
                new ObjectParameter("idUser", idUser) :
                new ObjectParameter("idUser", typeof(int));
    
            var userParameter = user != null ?
                new ObjectParameter("user", user) :
                new ObjectParameter("user", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var mailParameter = mail != null ?
                new ObjectParameter("mail", mail) :
                new ObjectParameter("mail", typeof(string));
    
            var idFunctionParameter = idFunction.HasValue ?
                new ObjectParameter("idFunction", idFunction) :
                new ObjectParameter("idFunction", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UserUpdate", idUserParameter, userParameter, passwordParameter, mailParameter, idFunctionParameter);
        }
    
        public virtual int NavigationUpdate(Nullable<int> id, string name, string location)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var locationParameter = location != null ?
                new ObjectParameter("location", location) :
                new ObjectParameter("location", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("NavigationUpdate", idParameter, nameParameter, locationParameter);
        }
    
        public virtual int CommentInsert(string text, Nullable<System.DateTime> date, string user)
        {
            var textParameter = text != null ?
                new ObjectParameter("text", text) :
                new ObjectParameter("text", typeof(string));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            var userParameter = user != null ?
                new ObjectParameter("user", user) :
                new ObjectParameter("user", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CommentInsert", textParameter, dateParameter, userParameter);
        }
    }
}
