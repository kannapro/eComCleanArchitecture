import FilterSection from './FilterSection';
import { DualRangeSlider } from '@/components/ui/dual-range-slider';

const PriceSection = () => {
  return (
    <FilterSection header="Price">
      <div className="my-2">
        <DualRangeSlider
          defaultValue={[50, 200]}
          min={0}
          max={250}
          step={1}
          label="₹"
        />
      </div>
    </FilterSection>
  );
};

export default PriceSection;