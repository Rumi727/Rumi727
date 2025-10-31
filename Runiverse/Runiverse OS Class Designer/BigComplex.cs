using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;

namespace RuniOS
{
    /// <summary>
    /// 한치의 오차도 없는 <b>매우 정확한 복소수</b>를 저장하고 계산합니다.<br/>
    /// 일종의 계산기 역할도 하는데, 미친 만능이라 무리수, 극한, 미적분, 방정식, <b>심지어는 소수마저</b> (2, 3, 5, 7 할 때 그 소수) 원하는 모든 계산을 완벽하게 한치의 오차도 없이 바로 계산합니다.
    /// <br/><br/>
    /// 모든 연산을 원자적으로 처리합니다. (Thread-safe)
    /// </summary>
    public struct BigComplex : ISignedNumber<BigComplex>, IBinaryInteger<BigComplex>
    {
        public static BigComplex NegativeOne => throw new NotImplementedException();
        public static BigComplex One => throw new NotImplementedException();
        public static int Radix => throw new NotImplementedException();
        public static BigComplex Zero => throw new NotImplementedException();
        public static BigComplex AdditiveIdentity => throw new NotImplementedException();
        public static BigComplex MultiplicativeIdentity => throw new NotImplementedException();

        public override readonly bool Equals([NotNullWhen(true)] object? obj) => throw new NotImplementedException();
        public readonly bool Equals(BigComplex other) => throw new NotImplementedException();

        public readonly int CompareTo(BigComplex other) => throw new NotImplementedException();

        public override readonly string ToString() => throw new NotImplementedException();
        public override readonly int GetHashCode() => throw new NotImplementedException();
        public readonly int CompareTo(object? obj) => throw new NotImplementedException();
        public static BigComplex Abs(BigComplex value) => throw new NotImplementedException();
        public static bool IsCanonical(BigComplex value) => throw new NotImplementedException();
        public static bool IsComplexNumber(BigComplex value) => throw new NotImplementedException();
        public static bool IsEvenInteger(BigComplex value) => throw new NotImplementedException();
        public static bool IsFinite(BigComplex value) => throw new NotImplementedException();
        public static bool IsImaginaryNumber(BigComplex value) => throw new NotImplementedException();
        public static bool IsInfinity(BigComplex value) => throw new NotImplementedException();
        public static bool IsInteger(BigComplex value) => throw new NotImplementedException();
        public static bool IsNaN(BigComplex value) => throw new NotImplementedException();
        public static bool IsNegative(BigComplex value) => throw new NotImplementedException();
        public static bool IsNegativeInfinity(BigComplex value) => throw new NotImplementedException();
        public static bool IsNormal(BigComplex value) => throw new NotImplementedException();
        public static bool IsOddInteger(BigComplex value) => throw new NotImplementedException();
        public static bool IsPositive(BigComplex value) => throw new NotImplementedException();
        public static bool IsPositiveInfinity(BigComplex value) => throw new NotImplementedException();
        public static bool IsRealNumber(BigComplex value) => throw new NotImplementedException();
        public static bool IsSubnormal(BigComplex value) => throw new NotImplementedException();
        public static bool IsZero(BigComplex value) => throw new NotImplementedException();
        public static BigComplex MaxMagnitude(BigComplex x, BigComplex y) => throw new NotImplementedException();
        public static BigComplex MaxMagnitudeNumber(BigComplex x, BigComplex y) => throw new NotImplementedException();
        public static BigComplex MinMagnitude(BigComplex x, BigComplex y) => throw new NotImplementedException();
        public static BigComplex MinMagnitudeNumber(BigComplex x, BigComplex y) => throw new NotImplementedException();
        public static BigComplex Parse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider) => throw new NotImplementedException();
        public static BigComplex Parse(string s, NumberStyles style, IFormatProvider? provider) => throw new NotImplementedException();
        public static bool TryConvertFromChecked<TOther>(TOther value, [MaybeNullWhen(false)] out BigComplex result) where TOther : INumberBase<TOther> => throw new NotImplementedException();
        public static bool TryConvertFromSaturating<TOther>(TOther value, [MaybeNullWhen(false)] out BigComplex result) where TOther : INumberBase<TOther> => throw new NotImplementedException();
        public static bool TryConvertFromTruncating<TOther>(TOther value, [MaybeNullWhen(false)] out BigComplex result) where TOther : INumberBase<TOther> => throw new NotImplementedException();
        public static bool TryConvertToChecked<TOther>(BigComplex value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther> => throw new NotImplementedException();
        public static bool TryConvertToSaturating<TOther>(BigComplex value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther> => throw new NotImplementedException();
        public static bool TryConvertToTruncating<TOther>(BigComplex value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther> => throw new NotImplementedException();
        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider, [MaybeNullWhen(false)] out BigComplex result) => throw new NotImplementedException();
        public static bool TryParse([NotNullWhen(true)] string? s, NumberStyles style, IFormatProvider? provider, [MaybeNullWhen(false)] out BigComplex result) => throw new NotImplementedException();
        public readonly bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider) => throw new NotImplementedException();
        public readonly string ToString(string? format, IFormatProvider? formatProvider) => throw new NotImplementedException();
        public static BigComplex Parse(ReadOnlySpan<char> s, IFormatProvider? provider) => throw new NotImplementedException();
        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, [MaybeNullWhen(false)] out BigComplex result) => throw new NotImplementedException();
        public static BigComplex Parse(string s, IFormatProvider? provider) => throw new NotImplementedException();
        public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out BigComplex result) => throw new NotImplementedException();
        public readonly int GetByteCount() => throw new NotImplementedException();
        public readonly int GetShortestBitLength() => throw new NotImplementedException();
        public static BigComplex PopCount(BigComplex value) => throw new NotImplementedException();
        public static BigComplex TrailingZeroCount(BigComplex value) => throw new NotImplementedException();
        public static bool TryReadBigEndian(ReadOnlySpan<byte> source, bool isUnsigned, out BigComplex value) => throw new NotImplementedException();
        public static bool TryReadLittleEndian(ReadOnlySpan<byte> source, bool isUnsigned, out BigComplex value) => throw new NotImplementedException();
        public readonly bool TryWriteBigEndian(Span<byte> destination, out int bytesWritten) => throw new NotImplementedException();
        public readonly bool TryWriteLittleEndian(Span<byte> destination, out int bytesWritten) => throw new NotImplementedException();
        public static bool IsPow2(BigComplex value) => throw new NotImplementedException();
        public static BigComplex Log2(BigComplex value) => throw new NotImplementedException();

        public static bool operator >(BigComplex left, BigComplex right) => throw new NotImplementedException();
        public static bool operator >=(BigComplex left, BigComplex right) => throw new NotImplementedException();
        public static bool operator <(BigComplex left, BigComplex right) => throw new NotImplementedException();
        public static bool operator <=(BigComplex left, BigComplex right) => throw new NotImplementedException();
        public static BigComplex operator %(BigComplex left, BigComplex right) => throw new NotImplementedException();
        public static BigComplex operator +(BigComplex left, BigComplex right) => throw new NotImplementedException();
        public static BigComplex operator --(BigComplex value) => throw new NotImplementedException();
        public static BigComplex operator /(BigComplex left, BigComplex right) => throw new NotImplementedException();
        public static bool operator ==(BigComplex left, BigComplex right) => throw new NotImplementedException();
        public static bool operator !=(BigComplex left, BigComplex right) => throw new NotImplementedException();
        public static BigComplex operator ++(BigComplex value) => throw new NotImplementedException();
        public static BigComplex operator *(BigComplex left, BigComplex right) => throw new NotImplementedException();
        public static BigComplex operator -(BigComplex left, BigComplex right) => throw new NotImplementedException();
        public static BigComplex operator -(BigComplex value) => throw new NotImplementedException();
        public static BigComplex operator +(BigComplex value) => throw new NotImplementedException();
        public static BigComplex operator &(BigComplex left, BigComplex right) => throw new NotImplementedException();
        public static BigComplex operator |(BigComplex left, BigComplex right) => throw new NotImplementedException();
        public static BigComplex operator ^(BigComplex left, BigComplex right) => throw new NotImplementedException();
        public static BigComplex operator ~(BigComplex value) => throw new NotImplementedException();
        public static BigComplex operator <<(BigComplex value, int shiftAmount) => throw new NotImplementedException();
        public static BigComplex operator >>(BigComplex value, int shiftAmount) => throw new NotImplementedException();
        public static BigComplex operator >>>(BigComplex value, int shiftAmount) => throw new NotImplementedException();
    }
}
