﻿namespace WpfApplication3
{
    public interface IDialogService : IDialogService<Answer>
    {
    }

    public interface IDialogService <T> where T : struct
    {
        T ShowDialogFor(IDialogViewModel<T> viewModel);
    }
}