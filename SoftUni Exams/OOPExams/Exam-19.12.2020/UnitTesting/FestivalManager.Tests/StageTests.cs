// Use this file for your unit tests.
// When you are ready to submit, REMOVE all using statements to Festival Manager (entities/controllers/etc)
// Test ONLY the Stage class. 
namespace FestivalManager.Tests
{
    using NUnit.Framework;
    using System;
    using System.Linq;

    [TestFixture]
    public class StageTests
    {
        [Test]
        public void SongReturn()
        {
            var stage = new Stage();

            TimeSpan ts = new TimeSpan(0, 1, 0);
            Song song = new Song("abc", ts);

            Performer performer = new Performer("Teo", "Yanchev", 20);

            stage.AddPerformer(performer);
            stage.AddSong(song);

            var actual = stage.AddSongToPerformer(song.Name, performer.FullName);
            var expected = $"{song} will be performed by {performer}";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddPerformance_ShouldThrowAE()
        {
            var stage = new Stage();

            var performer = new Performer("abc", "abc", 15);

            Assert.Throws<ArgumentException>(() =>
            {
                stage.AddPerformer(performer);
            });
        }

        [Test]
        public void AddPerformance_ShouldWork()
        {
            var stage = new Stage();

            var performer = new Performer("abc", "abc", 20);

            stage.AddPerformer(performer);

            int actual = stage.Performers.Count;
            int expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void NullException()
        {
            var stage = new Stage();

            Performer performer = null;

            Assert.Throws<ArgumentNullException>(() =>
            {

                stage.AddPerformer(performer);
            });
        }

        [Test]
        public void AddSong_ThrowExcAE()
        {
            var stage = new Stage();

            TimeSpan ts = new TimeSpan(0, 0, 0);
            Song song = new Song("abc", ts);

            Assert.Throws<ArgumentException>(() =>
            {

                stage.AddSong(song);
            });
        }

        [Test]
        public void AddSong_Works()
        {
            var stage = new Stage();

            TimeSpan ts = new TimeSpan(0, 1, 0);
            Song song = new Song("abc", ts);

            Performer performer = new Performer("Teo", "Yanchev", 20);

            stage.AddSong(song);
            stage.AddPerformer(performer);

            stage.AddSongToPerformer(song.Name, performer.FullName);

            var actual = performer.SongList.Count;
            var excpected = 1;

            Assert.AreEqual(excpected, actual);
        }


        [Test]
        public void Play_ShouldWork()
        {
            Performer performer1 = new Performer("Teo", "Yanchev", 20);
            Performer performer2 = new Performer("Tedo", "Yanchev", 21);

            TimeSpan ts1 = new TimeSpan(0, 1, 0);
            TimeSpan ts2 = new TimeSpan(0, 3, 4);
            TimeSpan ts3 = new TimeSpan(0, 3, 4);

            Song song1 = new Song("Neshto1", ts1);
            Song song2 = new Song("Neshto2", ts2);
            Song song3 = new Song("Neshto3", ts3);

            Stage stage = new Stage();

            stage.AddPerformer(performer1);
            stage.AddPerformer(performer2);

            stage.AddSong(song1);
            stage.AddSong(song2);
            stage.AddSong(song3);

            stage.AddSongToPerformer(song1.Name, performer1.FullName);
            stage.AddSongToPerformer(song2.Name, performer1.FullName);
            stage.AddSongToPerformer(song3.Name, performer1.FullName);
            stage.AddSongToPerformer(song1.Name, performer1.FullName);


            var actual = stage.Play();
            var expected = $"{2} performers played {4} songs";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PrivateGetPerformance_ThrowExc()
        {
            Stage stage = new Stage();

            Performer performer = new Performer("T", "Y", 20);

            TimeSpan ts = new TimeSpan(1, 1, 1);

            Song song = new Song("ABC", ts);

            stage.AddPerformer(performer);
            stage.AddSong(song);

            Assert.Throws<ArgumentException>(() =>
            {
                stage.AddSongToPerformer(song.Name, "T");
            });
        }

        [Test]
        public void PrivateGetSong_ThrowExc()
        {
            Stage stage = new Stage();

            Performer performer = new Performer("T", "Y", 20);

            TimeSpan ts = new TimeSpan(1, 1, 1);

            Song song = new Song("ABC", ts);

            stage.AddPerformer(performer);
            stage.AddSong(song);

            Assert.Throws<ArgumentException>(() =>
            {
                stage.AddSongToPerformer("S", performer.FullName);
            });
        }
    }
}