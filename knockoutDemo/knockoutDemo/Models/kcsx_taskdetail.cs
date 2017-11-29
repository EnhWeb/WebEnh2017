namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kcsx_taskdetail
    {
        public long Id { get; set; }

        public long TaskId { get; set; }

        public long QueId { get; set; }

        public short StatisticalState { get; set; }

        public short SortRank { get; set; }

        public short CorrectScore { get; set; }

        public int CompletionUserCount { get; set; }

        public short CorrectUserCount { get; set; }
    }
}
