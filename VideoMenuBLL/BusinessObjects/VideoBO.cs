using System;
using System.ComponentModel.DataAnnotations;

namespace VideoMenuBLL.BusinessObjects
{
    public class VideoBO
    {
        #region Properties

        // Id of the video
        public int Id { get; set; }

        // Name of the video
        [Required]
        [MaxLength(30)]
        [MinLength(2)]
        public string Title { get; set; }

        #endregion
    }

}
