using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVVMFramework.Localization
{
    public class ReEncodeQuestionTranslatable : Translatable
    {
        public ReEncodeQuestionTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Re-encode video?*";
    }
    public class CompleteLabelTranslatable : Translatable
    {
        public CompleteLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Complete";
    }
    public class ReverseLabelTranslatable : Translatable
    {
        public ReverseLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Reverse";
    }
    public class VideoTooBigMessageTranslatable : Translatable
    {
        public VideoTooBigMessageTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Video file exceeds 1 minute. If you continue it is possible your computer will run out of memory during the process and freeze. Do you still want to continue?";
    }
    public class SeekForwardLabelTranslatable : Translatable
    {
        public SeekForwardLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Forward (5 sec.)";
    }
    public class JumpToTimeLabelTranslatable : Translatable
    {
        public JumpToTimeLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Jump to time";
    }
    public class ConverterTranslatable : Translatable
    {
        public ConverterTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Converter";
    }
    public class AddChapterTranslatable : Translatable
    {
        public AddChapterTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Add Chapters";
    }
    public class VideoSuccessfullyConvertedTranslatable : Translatable
    {
        public VideoSuccessfullyConvertedTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Video successfully converted!";
    }
    public class VideoSuccessfullyReversedTranslatable : Translatable
    {
        public VideoSuccessfullyReversedTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Video successfully reversed!";
    }
    public class WarningLabelTranslatable : Translatable
    {
        public WarningLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Warning";
    }
    public class MergerTranslatable : Translatable
    {
        public MergerTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Merger";
    }
    public class ConfirmationLabelTranslatable : Translatable
    {
        public ConfirmationLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Confirmation";
    }
    public class MoveDownLabelTranslatable : Translatable
    {
        public MoveDownLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Move down";
    }
    public class CombiningSectionsLabelTranslatable : Translatable
    {
        public CombiningSectionsLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Combining sections...";
    }
    public class RamUsageLabelTranslatable : Translatable
    {
        public RamUsageLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "RAM usage exceeds {0}%.";
    }
    public class CombiningSectionsIntoOneLabelTranslatable : Translatable
    {
        public CombiningSectionsIntoOneLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Combining sections into one video...";
    }
    public class OutputFolderLabelTranslatable : Translatable
    {
        public OutputFolderLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Select output folder";
    }
    public class CancelLabelTranslatable : Translatable
    {
        public CancelLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Cancel";
    }
    public class OutputFormatQuestionTranslatable : Translatable
    {
        public OutputFormatQuestionTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Output to a different format?";
    }
    public class ChangingLabelTranslatable : Translatable
    {
        public ChangingLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Changing video speed...";
    }
    public class TrimmingSectionsLabelTranslatable : Translatable
    {
        public TrimmingSectionsLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Trimming video into sections...";
    }
    public class ReducingSizeLabelTranslatable : Translatable
    {
        public ReducingSizeLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Reducing video size...";
    }
    public class ConvertFormatLabelTranslatable : Translatable
    {
        public ConvertFormatLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Convert video format";
    }
    public class ReverseVideoMessageTranslatable : Translatable
    {
        public ReverseVideoMessageTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Reversing a video uses a lot of computer resources and can be time consuming. If you are going to reverse a video, make sure of the following:\n  1) It is best to not have other big programs running.\nAre you sure you want to continue?";
}
    public class SelectFileLabelTranslatable : Translatable
    {
        public SelectFileLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Click to select a file...";
    }
    public class CombineSectionsQuestionTranslatable : Translatable
    {
        public CombineSectionsQuestionTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Combine sections into one video?";
    }
    public class DeleteSectionConfirmTranslatable : Translatable
    {
        public DeleteSectionConfirmTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Do you want to delete this section?";
    }
    public class ImportLabelTranslatable : Translatable
    {
        public ImportLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Import Chapter File";
    }
    public class VideoCounterLabelTranslatable : Translatable
    {
        public VideoCounterLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Video {0} of {1}";
    }
    public class SizeReducerTranslatable : Translatable
    {
        public SizeReducerTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Size Reducer";
    }
    public class ConfirmTranslatable : Translatable
    {
        public ConfirmTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Confirm";
    }
    public class SettingMetadataMessageTranslatable : Translatable
    {
        public SettingMetadataMessageTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Setting metadata...";
    }
    public class ReversingSectionsLabelTranslatable : Translatable
    {
        public ReversingSectionsLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Reversing sections...";
    }
    public class OutputFormatLabelTranslatable : Translatable
    {
        public OutputFormatLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Output format";
    }
    public class MoveUpLabelTranslatable : Translatable
    {
        public MoveUpLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Move up";
    }
    public class NoFileSelectedTranslatable : Translatable
    {
        public NoFileSelectedTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "No file selected.";
    }
    public class SpeedChangerTranslatable : Translatable
    {
        public SpeedChangerTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Change Speed";
    }
    public class InsufficientTitlesTranslatable : Translatable
    {
        public InsufficientTitlesTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "There is not a title for every section. Click on the red sections to double check the title names.";
    }
    public class SplitterTranslatable : Translatable
    {
        public SplitterTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Splitter";
    }
    public class SeekBackLabelTranslatable : Translatable
    {
        public SeekBackLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Back (5 sec.)";
    }
    public class RemoveLabelTranslatable : Translatable
    {
        public RemoveLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Remove";
    }
    public class OperationCancelledTranslatable : Translatable
    {
        public OperationCancelledTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Operation cancelled.";
    }
    public class InformationLabelTranslatable : Translatable
    {
        public InformationLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Information";
    }
    public class ConvertLabelTranslatable : Translatable
    {
        public ConvertLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Convert";
    }
    public class VideoSpeedLabelTranslatable : Translatable
    {
        public VideoSpeedLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Video speed";
    }
    public class SizeSuccessfullyReducedTranslatable : Translatable
    {
        public SizeSuccessfullyReducedTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Size successfully reduced!";
    }
    public class ErrorLabelTranslatable : Translatable
    {
        public ErrorLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Error";
    }
    public class VideoSuccessfullySplitTranslatable : Translatable
    {
        public VideoSuccessfullySplitTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Video successfully split!";
    }
    public class ReduceVideoSizeLabelTranslatable : Translatable
    {
        public ReduceVideoSizeLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Reduce video size";
    }
    public class ChaptersSuccessfullyAddedTranslatable : Translatable
    {
        public ChaptersSuccessfullyAddedTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Chapters markers successfully added!";
    }
    public class ReverserTranslatable : Translatable
    {
        public ReverserTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Reverser";
    }
    public class SplitLabelTranslatable : Translatable
    {
        public SplitLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Split";
    }
    public class EndTimeLabelTranslatable : Translatable
    {
        public EndTimeLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "End time";
    }
    public class StopLabelTranslatable : Translatable
    {
        public StopLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Stop";
    }
    public class DownloaderTranslatable : Translatable
    {
        public DownloaderTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Youtube Downloader";
    }
    public class EndTimeAfterStartTimeTranslatable : Translatable
    {
        public EndTimeAfterStartTimeTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "End time must be after the start time. Please select the start time again.";
    }
    public class FormatLabelTranslatable : Translatable
    {
        public FormatLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Format";
    }
    public class PlayLabelTranslatable : Translatable
    {
        public PlayLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Play";
    }
    public class VideoEditorTranslatable : Translatable
    {
        public VideoEditorTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Video Editor";
    }
    public class AddChaptersMessageTranslatable : Translatable
    {
        public AddChaptersMessageTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Add chapter markers to video?";
    }

    public class AddChapterTitleTranslatable : Translatable
    {
        public AddChapterTitleTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Add chapter title";
    }

    public class PauseLabelTranslatable : Translatable
    {
        public PauseLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Pause";
    }
    public class ChapterFileFormatMessageTranslatable : Translatable
    {
        public ChapterFileFormatMessageTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Chapter file should be in the following format:";
    }
    public class VideoSpeedSuccessfullyChangedTranslatable : Translatable
    {
        public VideoSpeedSuccessfullyChangedTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Video speed successfully changed!";
    }
    public class ReduceSizeTranslatable : Translatable
    {
        public ReduceSizeTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Reduce Size";
    }
    public class MergeLabelTranslatable : Translatable
    {
        public MergeLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Merge";
    }
    public class GettingMetadataMessageTranslatable : Translatable
    {
        public GettingMetadataMessageTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Getting metadata...";
    }
    public class MergingLabelTranslatable : Translatable
    {
        public MergingLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Merging videos...";
    }
    public class ChapterAdderTryAgainTranslatable : Translatable
    {
        public ChapterAdderTryAgainTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Try again by importing the chapter marker file located at {0}.";
    }
    public class FlipLabelTranslatable : Translatable
    {
        public FlipLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Flip";
    }
    public class ConvertingLabelTranslatable : Translatable
    {
        public ConvertingLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Converting video...";
    }
    public class SplittingLabelTranslatable : Translatable
    {
        public SplittingLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Splitting video...";
    }
    public class ReEncodeCommentTranslatable : Translatable
    {
        public ReEncodeCommentTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "*Re-encoding is more time-consuming, but the start and end times will be more accurate and it will prevent any black frames at the beginning and end of the clips.";
    }
    public class ErrorOccurredTranslatable : Translatable
    {
        public ErrorOccurredTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "An error has occurred. Please close and reopen the program. Check your task manager and make sure any remaining \"ffmpeg.exe\" tasks are ended.";
}
    public class RotateLabelTranslatable : Translatable
    {
        public RotateLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Rotate";
    }
    public class VideoSuccessfullyMergedTranslatable : Translatable
    {
        public VideoSuccessfullyMergedTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Videos successfully merged!";
    }
    public class StartTimeLabelTranslatable : Translatable
    {
        public StartTimeLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Start time";
    }

    public class DownloadLabelTranslatable : Translatable
    {
        public DownloadLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Download";
    }

    public class DownloadingLabelTranslatable : Translatable
    {
        public DownloadingLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Downloading...";
    }

    public class AddUrlLabelTranslatable : Translatable
    {
        public AddUrlLabelTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Add URL";
    }

    public class VideoSuccessfullyDownloadedTranslatable : Translatable
    {
        public VideoSuccessfullyDownloadedTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Video successfully downloaded!";
    }

    public class IsPlaylistTranslatable : Translatable
    {
        public IsPlaylistTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Is this a playlist?";
    }

    public class EnterTitleTranslatable : Translatable
    {
        public EnterTitleTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Enter title...";
    }

    public class EnterUrlTranslatable : Translatable
    {
        public EnterUrlTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Enter URL...";
    }

    public class TextCannotBeEmptyTranslatable : Translatable
    {
        public TextCannotBeEmptyTranslatable(params object[] parameters) : base(parameters) { }
        protected override string GetDefaultTranslation() => "Text cannot be empty.";
    }


}
