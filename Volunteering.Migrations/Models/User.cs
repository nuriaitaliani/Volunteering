using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Volunteering.Migrations.Models
{
    /// <summary>
    /// User's class
    /// </summary>
    [Table("user")]
    public class User
    {
        /// <summary>
        /// Identifier
        /// </summary>
        [Key]
        [Column("id", Order = 0)]
        public Guid Id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [Required]
        [StringLength(maximumLength: 56)]
        [Column("name", Order = 1)]
        public string Name { get; set; }

        /// <summary>
        /// Last name
        /// </summary>
        [Required]
        [StringLength(maximumLength: 56)]
        [Column("last_name", Order = 2)]
        public string LastName { get; set; }

        /// <summary>
        /// DNI
        /// </summary>
        [Required]
        [StringLength(maximumLength: 16)]
        [Column("dni", Order = 3)]
        public string DNI { get; set; }

        /// <summary>
        /// Age
        /// </summary>
        [Column("age", Order = 4)]
        public int Age { get; set; }

        /// <summary>
        /// Phone number
        /// </summary>
        [Required]
        [DataType(DataType.PhoneNumber)]
        [StringLength(maximumLength: 16)]
        [Column("phone_number", Order = 5)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(maximumLength: 56)]
        [Column("email", Order = 6)]
        public string Email { get; set; }

        /// <summary>
        /// Creation date
        /// </summary>
        [Column("creation_date", Order = 7)]
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Update date
        /// </summary>
        [Column("update_date", Order = 8)]
        public DateTime? UpdateDate { get; set; }

        //public string FullName
        //{
        //    get { return string.Format("{0} {1}", Name, LastName); }
        //}

        #region Foreing Relations

        /// <summary>
        /// <see cref="UserSchedule"/>
        /// </summary>
        public virtual ICollection<UserSchedule> UserScheduleRelation { get; set; }

        #endregion Foreing Relations

    }
}
