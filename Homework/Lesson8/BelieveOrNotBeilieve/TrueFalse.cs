using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace BelieveOrNotBelieve
{
    //Класс для вопроса    
    [Serializable]
    public class Question
    {
        public string Text;//Текст вопроса
        public bool TrueFalse;//Правда или нет
        //Вообще-то мы здесь нарушаем правила инкапсуляции и эти поля нужно было бы реализовать
        //через открытые свойства, но для упрощения примера оставим так
        //Вам же предлагается сделать поля закрытыми и реализовать открыте свойства Text и TrueFalse

        //Для сериализации должен быть пустой конструктор.
        public Question()
        {
        }

        public Question(string text, bool trueFalse)
        {
            Text = text;
            TrueFalse = trueFalse;
        }        
    }

    //Класс для хранения списка вопросов. А так же для сериализации в XML и десериализации из XML
    public class TrueFalse
    {
        string _fileName;
        List<Question> _list;

        public string FileName
        {
            set { _fileName = value; }
        }

        public TrueFalse(string fileName)
        {           
            _fileName = fileName;
            _list = new List<Question>();
        }

        public void Add(string text, bool trueFalse)
        {
            _list.Add(new Question(text, trueFalse));
        }

        public void Remove(int index)
        {
            if (_list != null && index<_list.Count && index>=0) _list.RemoveAt(index);
        }

        //Индексатор - свойство для доступа к закрытому объекту
        public Question this[int index]
        {
            get
            {
                if (_list != null && index >= 0 && index < _list.Count)
                    return _list[index];
                throw new IndexOutOfRangeException("Выход за пределы списка вопросов");
            }
        }

        public void Save()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(_fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, _list);
            fStream.Close();
        }

        public void Load()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(_fileName, FileMode.Open, FileAccess.Read);
            _list = (List<Question>)xmlFormat.Deserialize(fStream);
            fStream.Close();
        }

        //public List<Question> List
        //{
        //    get { return list; }
        //}

        public int Count
        {
            get { return _list.Count; }
        }
    }
}
