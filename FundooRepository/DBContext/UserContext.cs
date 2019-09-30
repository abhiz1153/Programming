﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file=UserContext.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Abhishek Sharma"/>
// --------------------------------------------------------------------------------------------------------------------

namespace FundooRepository.DBContext
{
    using Common.Models;
    using Common.Models.LabelModels;
    using Common.Models.CollaboratorModel;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Common.Models.CollaboratorsModels;
    using Common.Models.AdminModels;

    /// <summary>
    /// Piblic class for UserContext
    /// </summary>
    /// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
    public class UserContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserContext"/> class.
        /// </summary>
        /// <param name="options">The options.</param>
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        { }
        /// <summary>
        /// Gets or sets the register.
        /// </summary>
        /// <value>
        /// The register.
        /// </value>
        public DbSet<UserModel> Register { get; set; }

       

        /// <summary>
        /// Gets or sets the notes.
        /// </summary>
        /// <value>
        /// The notes.
        /// </value>
        public DbSet<NotesModel> Notes { get; set; }
        
        public DbSet<LabelModel> Labels { get; set; }
        public DbSet<CollaboratorsModel> Collaborators { get; set; }
        public DbSet<AdminModel> Admin { get; set; }
        public DbSet<AdminLoginModel> AdminLogin { get; set; }
    }
}
