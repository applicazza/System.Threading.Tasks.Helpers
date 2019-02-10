# System.Threading.Tasks.Helpers

![](https://img.shields.io/nuget/v/Helpers.System.Threading.Tasks.svg?label=Helpers.System.Threading.Tasks&style=flat)

Various helpers for `System.Threading.Tasks`

## Usage

### AsyncLock

```csharp
public class Foo {

    private readonly AsyncLock _mutex = new AsyncLock();
    
    public async Task Bar() {
        using (await _mutex.LockAsync()) {
            // Do stuff
        }
    }
}
```

### WaitHandleHelper

```csharp
public class Foo {

    private readonly ManualResetEvent _baz = new ManualResetEvent(false);
    
    public async Task Bar() {
        await _baz.WaitOneAsync(CancellationToken.None);
    }
}
```

### CancellationTokenHelper

```csharp
public class Foo {

    public async Task Bar(CancellationToken token) {        
        await token.WhenCanceled();
    }
}
```

## License

MIT License

Copyright (c) 2019 Artyom Sokolov

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
