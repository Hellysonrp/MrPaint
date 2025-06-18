using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrPaint.Editor
{
    internal class History: IObservable<State>
    {
        public static History Instance { get; } = new History();

        #region IObservable<State> implementation
        private readonly HashSet<IObserver<State?>> _observers = new();

        public IDisposable Subscribe(IObserver<State?> observer)
        {
            if (_observers.Add(observer))
            {
                observer.OnNext(CurrentState);
            }
            return new Unsubscriber<State?>(_observers, observer);
        }

        private void Notify(State? state)
        {
            foreach (var observer in _observers)
            {
                observer.OnNext(state);
            }
        }
        #endregion

        public bool CanUndo => _states.Count > 0;
        public bool CanRedo => _redoStates.Count > 0;
        public State? CurrentState => _states.Count > 0 ? _states.Peek() : null;

        private readonly Stack<State> _states = new();
        private readonly Stack<State> _redoStates = new();

        public void AddState(State state)
        {
            _states.Push(state);
            _redoStates.Clear();
            Notify(state);
        }

        public State Undo()
        {
            if (_states.Count == 0) throw new InvalidOperationException("No states to undo.");
            var state = _states.Pop();
            _redoStates.Push(state);
            Notify(CurrentState);
            return state;
        }

        public State Redo()
        {
            if (_redoStates.Count == 0) throw new InvalidOperationException("No states to redo.");
            var state = _redoStates.Pop();
            _states.Push(state);
            Notify(state);
            return state;
        }

        public void Clear()
        {
            foreach (State item in _states)
                item.Dispose();
            foreach (State item in _redoStates)
                item.Dispose();
            _states.Clear();
            _redoStates.Clear();
            Notify(null);
        }
    }
}
