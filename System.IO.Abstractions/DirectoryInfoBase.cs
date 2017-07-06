﻿using System.Collections.Generic;
using System.Security.AccessControl;

namespace System.IO.Abstractions
{
  [Serializable]
  public abstract class DirectoryInfoBase : FileSystemInfoBase
  {
    public abstract void Create();
    public abstract DirectoryInfoBase CreateSubdirectory(string path);
    public abstract void Delete(bool recursive);
    public abstract IEnumerable<DirectoryInfoBase> EnumerateDirectories();
    public abstract IEnumerable<DirectoryInfoBase> EnumerateDirectories(string searchPattern);
    public abstract IEnumerable<DirectoryInfoBase> EnumerateDirectories(string searchPattern, SearchOption searchOption);
    public abstract IEnumerable<FileInfoBase> EnumerateFiles();
    public abstract IEnumerable<FileInfoBase> EnumerateFiles(string searchPattern);
    public abstract IEnumerable<FileInfoBase> EnumerateFiles(string searchPattern, SearchOption searchOption);
    public abstract IEnumerable<FileSystemInfoBase> EnumerateFileSystemInfos();
    public abstract IEnumerable<FileSystemInfoBase> EnumerateFileSystemInfos(string searchPattern);
    public abstract IEnumerable<FileSystemInfoBase> EnumerateFileSystemInfos(string searchPattern, SearchOption searchOption);
    public abstract DirectoryInfoBase[] GetDirectories();
    public abstract DirectoryInfoBase[] GetDirectories(string searchPattern);
    public abstract DirectoryInfoBase[] GetDirectories(string searchPattern, SearchOption searchOption);
    public abstract FileInfoBase[] GetFiles();
    public abstract FileInfoBase[] GetFiles(string searchPattern);
    public abstract FileInfoBase[] GetFiles(string searchPattern, SearchOption searchOption);
    public abstract FileSystemInfoBase[] GetFileSystemInfos();
    public abstract FileSystemInfoBase[] GetFileSystemInfos(string searchPattern);
    public abstract FileSystemInfoBase[] GetFileSystemInfos(string searchPattern, SearchOption searchOption);
    public abstract void MoveTo(string destDirName);
    public abstract DirectoryInfoBase Parent { get; }
    public abstract DirectoryInfoBase Root { get; }

    public static implicit operator DirectoryInfoBase(DirectoryInfo directoryInfo)
    {
      if (directoryInfo == null)
        return null;
      return new DirectoryInfoWrapper(directoryInfo);
    }
  }
}