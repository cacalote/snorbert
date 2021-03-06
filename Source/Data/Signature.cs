﻿using NPoco;

namespace snorbert.Data
{
    /// <summary>
    /// 
    /// </summary>
    public class Signature
    {
        #region Member Variables
        [Column("sig_id")]
        public long Id { get; set; }
        [Column("sig_sid")]
        public string Sid { get; set; }
        [Column("sig_gid")]
        public string Gid { get; set; }
        [Column("sig_name")]
        public string Name { get; set; }
        [Column("sig_priority")]
        public string Priority { get; set; }
        [Column("count")]
        public long Count { get; set; }
        [Ignore]
        public string Text { get; set; }
        [Ignore]
        public bool Updated { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// 
        /// </summary>
        public Signature()
        {
            Sid = string.Empty;
            Name = string.Empty;
            Priority = string.Empty;
            Text = string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="text"></param>
        /// <param name="sid"></param>
        /// <param name="priority"></param>
        /// <param name="count"></param>
        public Signature(long id, 
                    string text, 
                    string sid, 
                    string priority, 
                    int count)
        {
            Id = id;
            Text = text;
            Sid = sid;
            Priority = priority;
            Count = count;
        }
        #endregion
    }
}
