set deviceIndex=%1
mkdir temp
cd temp
mkdir IsolatedStore
cd IsolatedStore
"C:\Program Files (x86)\Microsoft SDKs\Windows Phone\v8.0\Tools\IsolatedStorageExplorerTool\ISETool.exe" rs deviceindex:%deviceIndex% 4582d0ba-feb0-4334-a399-c49822c51af7 
