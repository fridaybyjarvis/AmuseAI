namespace Amuse.Common
{
    public sealed record ExecutionOptions
    {
        public int MemoryReserve { get; set; } = 1;
        public bool IsPrefetchEnabled { get; set; } = true;
        public bool IsSegmentedComputeEnabled { get; set; } = true;
        public bool IsAutoEncoderCpuEnabled { get; set; }
        public bool IsControlNetCpuEnabled { get; set; }
        public bool IsTextEncoderCpuEnabled { get; set; }

        public AutoOption AutoEncoderConvDirect { get; set; }
        public AutoOption DiffusionConvDirect { get; set; }
        public AutoOption ControlNetConvDirect { get; set; }
        public AutoOption TextEncoderConvDirect { get; set; }

        public AutoOption AutoEncoderFlashAttention { get; set; }
        public AutoOption DiffusionFlashAttention { get; set; }
        public AutoOption ControlNetFlashAttention { get; set; }
        public AutoOption TextEncoderFlashAttention { get; set; }
        public bool IsSageAttentionEnabled { get; set; }
    }
}
