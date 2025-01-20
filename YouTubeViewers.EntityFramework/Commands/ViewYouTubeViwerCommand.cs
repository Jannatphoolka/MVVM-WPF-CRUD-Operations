//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Input;
//using YouTubeViewers.Domain.Commands;
//using YouTubeViewers.Domain.Models;
//using YouTubeViewers.EntityFramework.DTOs;

//namespace YouTubeViewers.EntityFramework.Commands
//{
//    class ViewYouTubeViwerCommand : ICommand
//    {
//        //private readonly YouTubeViewersDbContextFactory _contextFactory;

//        //public ViewYouTubeViewerCommand(YouTubeViewersDbContextFactory contextFactory)
//        //{
//        //    _contextFactory = contextFactory;
//        //}

//        //public async Task Execute(YouTubeViewer youTubeViewer)
//        //{
//        //    using (YouTubeViewersDbContext context = _contextFactory.Create())
//        //    {
//        //        YouTubeViewerDto youTubeViewerDto = new YouTubeViewerDto()
//        //        {
//        //            Id = youTubeViewer.Id,
//        //            Username = youTubeViewer.Username,
//        //            IsSubscribed = youTubeViewer.IsSubscribed,
//        //            IsMember = youTubeViewer.IsMember,
//        //        };

//        //        context.YouTubeViewers.Update(youTubeViewerDto);
//        //        await context.SaveChangesAsync();
//        //    }
//        //}
//        private Action DoWork;
//        public event EventHandler CanExecuteChanged;

//        public ViewYouTubeViwerCommand(Action work)
//        {
//            DoWork = work;
//        }
//        public bool CanExecute(object parameter)
//        {
//            return true;
//        }

//        public void Execute(object parameter)
//        {
//            DoWork();
//        }
//    }
//}
