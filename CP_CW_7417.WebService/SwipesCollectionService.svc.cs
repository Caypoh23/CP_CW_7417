using CP_CW_7417.BLL.Enums;
using CP_CW_7417.BLL.Models;
using CP_CW_7417.DAL.Repositories;
using SynConnectDLL;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;

namespace CP_CW_7417.WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SwipesCollectionService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SwipesCollectionService.svc or SwipesCollectionService.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode =
        InstanceContextMode.Single)]
    public class SwipesCollectionService : ISwipesCollectionService
    {
        #region Properties

        private static List<Terminal> _terminals = new List<Terminal>();

        private Semaphore _semaphore = new Semaphore(3, 3);

        private SynConnection _connection = SynConnection.GetInstance();

        private IRepository _repository;

        #endregion

        public SwipesCollectionService(SwipeRepository repository)
        {
            _repository = repository;
        }

        // get the status of terminals
        public List<Terminal> GetStatus() => _terminals;

        // get all swipes using repository method
        public List<Swipe> GetAllSwipes() => _repository.GetSwipes();

        public void StartCollectingSwipes()
        {
            _terminals.Clear();

            Random random = new Random();

            // creating 10 terminals and start the threads
            for (int i = 0; i < 10; i++)
            {
                _terminals.Add(new Terminal(random));
                var thread = new Thread(RetreiveSwipes);
                thread.Start(i);
            }
        }

        private void RetreiveSwipes(object obj)
        {
            var index = (int)obj;
            var terminal = _terminals[index];

            terminal.SwipeStatus = SwipeStatus.Waiting;
            
            // allow only 3 swipes at a time
            _semaphore.WaitOne();

            terminal.SwipeStatus = SwipeStatus.InProcess;

            var swipesStr = _connection.RetrieveSwipes(terminal.IPAddress);

            var swipes = ParseSwipeData(swipesStr, terminal.IPAddress);

            // add swipes to db using repository method
            _repository.AddSwipes(swipes);

            terminal.SwipeStatus = SwipeStatus.Finished;

            _semaphore.Release();
        }

        // parse the data from dll file
        private List<Swipe> ParseSwipeData(string data, string ipAddress)
        {
            var swipesData = data.Split('\n');

            var swipes = new List<Swipe>();

            foreach (var item in swipesData)
            {
                var splittedSwipe = item.Split(',');

                var swipe = new Swipe(ipAddress, splittedSwipe);

                swipes.Add(swipe);
            }

            return swipes;
        }
    }
}
