while (true)
{
    UnsafeNativeMethods.IMsoComponent msoComponent3 = ((trackingComponent != null) ? trackingComponent : ((activeComponent == null) ? msoComponent2 : activeComponent));
    if (UnsafeNativeMethods.PeekMessage(ref msg, NativeMethods.NullHandleRef, 0, 0, 0))
    {
        array[0] = msg;
        flag = msoComponent3.FContinueMessageLoop(reason, pvLoopData, array);
        if (!flag)
        {
            continue;
        }
        if (msg.hwnd != IntPtr.Zero && SafeNativeMethods.IsWindowUnicode(new HandleRef(null, msg.hwnd)))
        {
            flag2 = true;
            UnsafeNativeMethods.GetMessageW(ref msg, NativeMethods.NullHandleRef, 0, 0);
        }
        else
        {
            flag2 = false;
            UnsafeNativeMethods.GetMessageA(ref msg, NativeMethods.NullHandleRef, 0, 0);
        }
        if (msg.message == 18)
        {
            ThreadContext.FromCurrent().DisposeThreadWindows();
            if (reason != -1)
            {
                UnsafeNativeMethods.PostQuitMessage((int)msg.wParam);
            }
            flag = false;
            break;
        }
        if (!msoComponent3.FPreTranslateMessage(ref msg))
        {
            UnsafeNativeMethods.TranslateMessage(ref msg);
            if (flag2)
            {
                UnsafeNativeMethods.DispatchMessageW(ref msg);
            }
            else
            {
                UnsafeNativeMethods.DispatchMessageA(ref msg);
            }
        }
        continue;
    }
    if (reason == 2 || reason == -2)
    {
        break;
    }
    bool flag3 = false;
    if (OleComponents != null)
    {
        IEnumerator enumerator = OleComponents.Values.GetEnumerator();
        while (enumerator.MoveNext())
        {
            ComponentHashtableEntry componentHashtableEntry2 = (ComponentHashtableEntry)enumerator.Current;
            flag3 |= componentHashtableEntry2.component.FDoIdle(-1);
        }
    }
    flag = msoComponent3.FContinueMessageLoop(reason, pvLoopData, null);
    if (flag)
    {
        if (flag3)
        {
            UnsafeNativeMethods.MsgWaitForMultipleObjectsEx(0, IntPtr.Zero, 100, 255, 4);
        }
        else if (!UnsafeNativeMethods.PeekMessage(ref msg, NativeMethods.NullHandleRef, 0, 0, 0))
        {
            UnsafeNativeMethods.WaitMessage();
        }
    }
    else
    {
        break;
    }
}
