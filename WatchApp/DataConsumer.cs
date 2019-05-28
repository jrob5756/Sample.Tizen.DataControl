using System;
using ServiceApp;
using Tizen;
using Tizen.Applications;
using Tizen.Applications.DataControl;

namespace WatchApp
{
    public class DataConsumer : Consumer
    {
        public DataConsumer() : base("http://org.tizen.example.ServiceApp/datacontrol/provider/test", "sample-data-provider")
        {

        }

        protected override void OnDataChange(ChangeType type, Bundle data)
        {
            Log.Info(Constants.LogTag, "Received data change event!!!");
            base.OnDataChange(type, data);
        }

        protected override void OnDataChangeListenResult(DataChangeListenResult result)
        {
            Log.Info(Constants.LogTag, $"Data change listen result {result.Result}");
        }

        #region Not Implemented

        protected override void OnSelectResult(SelectResult result)
        {
            throw new NotImplementedException();
        }

        protected override void OnInsertResult(InsertResult result)
        {
            throw new NotImplementedException();
        }

        protected override void OnUpdateResult(UpdateResult result)
        {
            throw new NotImplementedException();
        }

        protected override void OnDeleteResult(DeleteResult result)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}