using Circularqueue;
int [] arr = new int[3];
CircularQueue cq = new CircularQueue(capacity:3);





cq.Log(3);
cq.Log(4);
cq.Log(5);
cq.Log(7);
cq.Read();
cq.Log(10);
cq.Read();
cq.Read();
cq.Read();

cq.Read();

cq.Log(7);
cq.Log(15);
cq.Read();