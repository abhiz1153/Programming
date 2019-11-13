// --------------------------------------------------------------------------------------------------------------------
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
    using Common.Models.NotesLabelsModels;

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

        /// <summary>
        /// Gets or sets the labels.
        /// </summary>
        /// <value>
        /// The labels.
        /// </value>
        public DbSet<LabelModel> Labels { get; set; }

        /// <summary>
        /// Gets or sets the collaborators.
        /// </summary>
        /// <value>
        /// The collaborators.
        /// </value>
        public DbSet<CollaboratorsModel> Collaborators { get; set; }

        /// <summary>
        /// Gets or sets the admin.
        /// </summary>
        /// <value>
        /// The admin.
        /// </value>
        public DbSet<AdminModel> Admin { get; set; }

        /// <summary>
        /// Gets or sets the admin login.
        /// </summary>
        /// <value>
        /// The admin login.
        /// </value>
        public DbSet<AdminLoginModel> AdminLogin { get; set; }

        /// <summary>
        /// Gets or sets the notes label models.
        /// </summary>
        /// <value>
        /// The notes label models.
        /// </value>
        public DbSet<NoteLabelModel> NotesLabelModels { get; set; }
    }
}
