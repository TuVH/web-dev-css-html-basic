using System;


namespace Test
{
    class LinkList
    {
        Note phead = null;
        
        public void AddNote(object data)
        {
            if (phead == null)
            {
                Note newNote = new Note(data);
                newNote.Next = phead;
                phead = newNote;
            }
            else
            {
                Note current = phead;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new Note(data);
            }
           
        }
        public void ShowNote()
        {
            Note tmpN = phead;
            while (tmpN != null)
            {
                Console.Write(tmpN.data + "--->");
                tmpN = tmpN.Next;
            }
        }
        public void AddFirst(object data)
        {
            if (phead == null)
            {
                Note newNote = new Note(data);
                newNote.Next = phead;
                phead = newNote;
            }
            else
            {
                Note firstNote = new Note(data);
                firstNote.Next = phead;
                phead = firstNote;
            }
        }
        public void Addmid(object data, int pos)
        {
            if (phead == null)
            {
                Note newNote = new Note(data);
                newNote.Next = phead;
                phead = newNote;
            }
            else
            {
                Note midNote = new Note(data);
                Note pPreNote = null;
                Note pIntsertNote = phead;
                int i = 0;
                while (pIntsertNote!=null)
                {
                    if (i == pos)
                    {
                        break;
                    }
                    pPreNote = pIntsertNote;
                    pIntsertNote = pIntsertNote.Next;
                    i++;
                }
                pPreNote.Next = midNote;
                midNote.Next = pIntsertNote;
            }
        }
        public void Delete(int pos)
        {
            Note pPreNote = null;
            Note pMidNote = phead;
            int i = 0;
            while (pMidNote!= null)
            {
                if (i == pos)
                {
                    break;
                }
                pPreNote = pMidNote;
                pMidNote = pMidNote.Next;
                i++;
            }
            pPreNote.Next = pMidNote.Next;
            pMidNote.Next = null;
        }
    }
}
