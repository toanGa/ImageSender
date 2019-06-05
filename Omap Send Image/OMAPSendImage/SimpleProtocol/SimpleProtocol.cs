using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OMAPSendImage.SimpleProtocol
{
    /// <summary>
    /// Protocol
    /// | Start Byte | Content Header | ... Data ... | Stop Byte |
    /// </summary>
    struct ContenHeader
    {
        Byte Command;
        UInt32 DataLen;
        // May be CRC
    }

    struct ObjectTransfer
    {
        Byte StartByte;
        ContenHeader Header;
        Byte[] Content;
        Byte StopByte;
    }


    class SimpleProtocol
    {
        ConcurrentQueue<Byte[]> mQueueRecv = new ConcurrentQueue<Byte[]>();
        ObjectTransfer objectTransfer = new ObjectTransfer();
        ManualResetEvent RecvEvent = new ManualResetEvent(false);
        ObjectTransferFinished TransferFinished;
        delegate void ObjectTransferFinished();


        // Received in background thread
        public void BackGroundReceiveByteArray(Byte[] arrRev)
        {
            mQueueRecv.Enqueue(arrRev);

            RecvEvent.Set();
        }

        public void ForgroundHandlerRecv()
        {
            byte[] DequeueByte;
            bool status = mQueueRecv.TryDequeue(out DequeueByte);
            if(status)
            {
                TransferFinished();
            }
        }
    }
}
