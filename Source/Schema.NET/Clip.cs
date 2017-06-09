namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A short TV or radio program or a segment/part of a program.
    /// </summary>
    [DataContract]
    public class Clip : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Clip";

        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "actor", Order = 2)]
        public Person Actor { get; set; }

        /// <summary>
        /// Position of the clip within an ordered group of clips.
        /// </summary>
        [DataMember(Name = "clipNumber", Order = 3)]
        public object ClipNumber { get; protected set; }

        /// <summary>
        /// Position of the clip within an ordered group of clips.
        /// </summary>
        [IgnoreDataMember]
        public int? ClipNumberInteger
        {
            get => this.ClipNumber as int?;
            set => this.ClipNumber = value;
        }

        /// <summary>
        /// Position of the clip within an ordered group of clips.
        /// </summary>
        [IgnoreDataMember]
        public string ClipNumberText
        {
            get => this.ClipNumber as string;
            set => this.ClipNumber = value;
        }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "director", Order = 4)]
        public Person Director { get; set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        [DataMember(Name = "musicBy", Order = 5)]
        public object MusicBy { get; protected set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        [IgnoreDataMember]
        public Person MusicByPerson
        {
            get => this.MusicBy as Person;
            set => this.MusicBy = value;
        }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        [IgnoreDataMember]
        public MusicGroup MusicByMusicGroup
        {
            get => this.MusicBy as MusicGroup;
            set => this.MusicBy = value;
        }

        /// <summary>
        /// The episode to which this clip belongs.
        /// </summary>
        [DataMember(Name = "partOfEpisode", Order = 6)]
        public Episode PartOfEpisode { get; set; }

        /// <summary>
        /// The season to which this episode belongs.
        /// </summary>
        [DataMember(Name = "partOfSeason", Order = 7)]
        public CreativeWorkSeason PartOfSeason { get; set; }

        /// <summary>
        /// The series to which this episode or season belongs.
        /// </summary>
        [DataMember(Name = "partOfSeries", Order = 8)]
        public CreativeWorkSeries PartOfSeries { get; set; }
    }
}