using System;
using System.Threading;
using Tizen;
using Tizen.Applications;
using Tizen.Applications.DataControl;

namespace ServiceApp
{
    public class DataProvider : Provider
    {
        private readonly Timer _timer;

        public DataProvider() : base("sample-data-provider")
        {
            Log.Info(Constants.LogTag, "Created Data Provider");
            _timer = new Timer(TimerTick, null, TimeSpan.FromSeconds(30), TimeSpan.FromMilliseconds(-1));
        }

        protected override DataChangeListenResult OnDataChangeListenRequest(string requestAppID)
        {
            Log.Info(Constants.LogTag, $"Data change requested by {requestAppID}");
            return new DataChangeListenResult(ResultType.Success);
        }

        private void TimerTick(object state)
        {
            try
            {
                Log.Info(Constants.LogTag, "Ticked");

                SendDataChange(ChangeType.Update, new Bundle());

                _timer.Change(TimeSpan.FromSeconds(10), TimeSpan.FromMilliseconds(-1));
            }
            catch (Exception e)
            {
                Log.Error(Constants.LogTag, $"{e}");
            }
        }

        #region Not Implemented

        protected override SelectResult OnSelect(string query, string @where, string[] columList, int columnCount, string order, int pageNum, int countPerPage)
        {
            throw new NotImplementedException();
        }

        protected override InsertResult OnInsert(string query, Bundle insertData)
        {
            throw new NotImplementedException();
        }

        protected override UpdateResult OnUpdate(string query, string @where, Bundle updateData)
        {
            throw new NotImplementedException();
        }

        protected override DeleteResult OnDelete(string query, string @where)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
