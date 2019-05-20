using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Models.Models
{
    public class BusinessEntity : INotifyPropertyChanged, IDisposable
    {
        public long Id { get; set; }

        public bool IsDirty { get; private set; }

        public bool IsNew { get; private set; }

        public bool IsDeleted { get; private set; }

        public bool IsOld => !IsNew && !IsDirty && !IsDeleted;

        public event PropertyChangedEventHandler PropertyChanged;

        public BusinessEntity()
        {
            PropertyChanged += OnPropertyChanged;
        }

        public void MarkDirty()
        {
            IsDirty = true;
        }

        public void MarkNew()
        {
            IsNew = true;
            IsDirty = true;
            IsDeleted = false;
        }

        public void MarkOld()
        {
            IsNew = false;
            IsDirty = false;
            IsDeleted = false;
        }

        public void MarkDeleted()
        {
            IsDeleted = true;
            IsDirty = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                PropertyChanged -= OnPropertyChanged;
            }
        }

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = @"")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected virtual void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (!IsDirty)
            {
                MarkDirty();
            }
        }
    }
}