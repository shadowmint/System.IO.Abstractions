﻿using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;

namespace System.IO.Abstractions
{
    [Serializable]
    public class DirectoryInfoWrapper : DirectoryInfoBase
    {
        private readonly DirectoryInfo instance;

        public DirectoryInfoWrapper(DirectoryInfo instance)
        {
            if (instance == null)
            {
                throw new ArgumentNullException("instance");
            }

            this.instance = instance;
        }

        public override void Delete()
        {
            instance.Delete();
        }

        public override void Refresh()
        {
            instance.Refresh();
        }

        public override FileAttributes Attributes
        {
            get { return instance.Attributes; }
            set { instance.Attributes = value; }
        }

        public override DateTime CreationTime
        {
            get { return instance.CreationTime; }
            set { instance.CreationTime = value; }
        }

        public override DateTime CreationTimeUtc
        {
            get { return instance.CreationTimeUtc; }
            set { instance.CreationTimeUtc = value; }
        }

        public override bool Exists
        {
            get { return instance.Exists; }
        }

        public override string Extension
        {
            get { return instance.Extension; }
        }

        public override string FullName
        {
            get { return instance.FullName; }
        }

        public override DateTime LastAccessTime
        {
            get { return instance.LastAccessTime; }
            set { instance.LastAccessTime = value; }
        }

        public override DateTime LastAccessTimeUtc
        {
            get { return instance.LastAccessTimeUtc; }
            set { instance.LastAccessTimeUtc = value; }
        }

        public override DateTime LastWriteTime
        {
            get { return instance.LastWriteTime; }
            set { instance.LastWriteTime = value; }
        }

        public override DateTime LastWriteTimeUtc
        {
            get { return instance.LastWriteTimeUtc; }
            set { instance.LastWriteTimeUtc = value; }
        }

        public override string Name
        {
            get { return instance.Name; }
        }

        public override void Create()
        {
            instance.Create();
        }

        public override DirectoryInfoBase CreateSubdirectory(string path)
        {
            return new DirectoryInfoWrapper(instance.CreateSubdirectory(path));
        }

        public override void Delete(bool recursive)
        {
            instance.Delete(recursive);
        }

        public override IEnumerable<DirectoryInfoBase> EnumerateDirectories()
        {
            return instance.EnumerateDirectories().Select(directoryInfo => new DirectoryInfoWrapper(directoryInfo));
        }

        public override IEnumerable<DirectoryInfoBase> EnumerateDirectories(string searchPattern)
        {
            return instance.EnumerateDirectories(searchPattern).Select(directoryInfo => new DirectoryInfoWrapper(directoryInfo));
        }

        public override IEnumerable<DirectoryInfoBase> EnumerateDirectories(string searchPattern, SearchOption searchOption)
        {
            return instance.EnumerateDirectories(searchPattern, searchOption).Select(directoryInfo => new DirectoryInfoWrapper(directoryInfo));
        }

        public override IEnumerable<FileInfoBase> EnumerateFiles()
        {
            return instance.EnumerateFiles().Select(fileInfo => new FileInfoWrapper(fileInfo));
        }

        public override IEnumerable<FileInfoBase> EnumerateFiles(string searchPattern)
        {
            return instance.EnumerateFiles(searchPattern).Select(fileInfo => new FileInfoWrapper(fileInfo));
        }

        public override IEnumerable<FileInfoBase> EnumerateFiles(string searchPattern, SearchOption searchOption)
        {
            return instance.EnumerateFiles(searchPattern, searchOption).Select(fileInfo => new FileInfoWrapper(fileInfo));
        }

        public override IEnumerable<FileSystemInfoBase> EnumerateFileSystemInfos()
        {
            return instance.EnumerateFileSystemInfos().WrapFileSystemInfos();
        }

        public override IEnumerable<FileSystemInfoBase> EnumerateFileSystemInfos(string searchPattern)
        {
            return instance.EnumerateFileSystemInfos(searchPattern).WrapFileSystemInfos();
        }

        public override IEnumerable<FileSystemInfoBase> EnumerateFileSystemInfos(string searchPattern, SearchOption searchOption)
        {
            return instance.EnumerateFileSystemInfos(searchPattern, searchOption).WrapFileSystemInfos();
        }

        public override DirectoryInfoBase[] GetDirectories()
        {
            return instance.GetDirectories().WrapDirectories();
        }

        public override DirectoryInfoBase[] GetDirectories(string searchPattern)
        {
            return instance.GetDirectories(searchPattern).WrapDirectories();
        }

        public override DirectoryInfoBase[] GetDirectories(string searchPattern, SearchOption searchOption)
        {
            return instance.GetDirectories(searchPattern, searchOption).WrapDirectories();
        }

        public override FileInfoBase[] GetFiles()
        {
            return instance.GetFiles().WrapFiles();
        }

        public override FileInfoBase[] GetFiles(string searchPattern)
        {
            return instance.GetFiles(searchPattern).WrapFiles();
        }

        public override FileInfoBase[] GetFiles(string searchPattern, SearchOption searchOption)
        {
            return instance.GetFiles(searchPattern, searchOption).WrapFiles();
        }

        public override FileSystemInfoBase[] GetFileSystemInfos()
        {
            return instance.GetFileSystemInfos().WrapFileSystemInfos();
        }

        public override FileSystemInfoBase[] GetFileSystemInfos(string searchPattern)
        {
            return instance.GetFileSystemInfos(searchPattern).WrapFileSystemInfos();
        }

        public override FileSystemInfoBase[] GetFileSystemInfos(string searchPattern, SearchOption searchOption)
        {
            return instance.GetFileSystemInfos(searchPattern, searchOption).WrapFileSystemInfos();
        }

        public override void MoveTo(string destDirName)
        {
            instance.MoveTo(destDirName);
        }

        public override DirectoryInfoBase Parent
        {
            get { return instance.Parent; }
        }

        public override DirectoryInfoBase Root
        {
            get { return instance.Root; }
        }

        public override string ToString()
        {
            return instance.ToString();
        }
    }
}